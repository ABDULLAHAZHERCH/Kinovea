/*
Copyright � Joan Charmant 2008.
jcharmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.

*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Kinovea.ScreenManager.Languages;

namespace Kinovea.ScreenManager
{
    public class DrawingToolPointer : AbstractDrawingTool
    {
        #region Events
        /// <summary>
        /// This event is raised while the drawing is being manipulated with the hand tool.
        /// The DrawingAction contains the motion type:
        /// - Moving, Resizing: while actively moving (repeated events).
        /// - Moved, Resized: on mouse up (single event).
        /// </summary>
        public EventHandler<DrawingEventArgs> DrawingModified;
        #endregion

        #region Enum
        private enum SelectedObjectType
        {
            None,
            Track,   
            Chrono,  
            Drawing,
            SingletonDrawing,
        }
        #endregion
        
        #region Properties
        public override string Name
        {
            get { return "Pointer"; }
        }
        public override string DisplayName
        {
            get { return ScreenManagerLang.ToolTip_DrawingToolPointer; }
        }
        public override Bitmap Icon
        {
            get { return Kinovea.ScreenManager.Properties.Drawings.handtool4; }
        }
        public override bool Attached
        {
            get { return false; }
        }
        public override bool KeepTool
        {
            get { return true; }
        }
        public override bool KeepToolFrameChanged
        {
            get { return true; }
        }
        public override StyleElements StyleElements
        {
            get	{ throw new NotImplementedException(); }
            set	{ throw new NotImplementedException(); }
        }
        public override StyleElements DefaultStyleElements
        {
            get	{ throw new NotImplementedException(); }
        }
        
        /// <summary>
        /// Delta between the current location and the previous location.
        /// </summary>
        public PointF MouseDelta
        {
            get { return mouseDelta; }
        }

        /// <summary>
        /// Delta between the current location and the initial mouse down.
        /// </summary>
        public PointF MouseDeltaOrigin
        {
            get { return mouseDeltaOrigin; }
        }

        /// <summary>
        /// Timestamp at the initial mouse down.
        /// </summary>
        public long OriginTime
        {
            get { return originTime; }
        }
        #endregion

        #region Members
        //--------------------------------------------------------------------
        // We do not keep the strecth/zoom factor here.
        // All coordinates must be given in image coordinates.
        //--------------------------------------------------------------------
        private ManipulationType manipulationType;
        private SelectedObjectType selectedObjectType;
        private PointF lastPoint;
        private PointF originPoint;
        private PointF mouseDelta;
        private PointF mouseDeltaOrigin;
        private long originTime;
        private Point directZoomTopLeft;
        private int resizingHandle;
        private Size imgSize;
        private Cursor cursorHandClose;
        private int lastCursorType = 0;

        // Solo mode
        private bool isSolo = false;
        private Guid soloId = Guid.Empty;
        private bool configureTracking = false;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Constructor
        public DrawingToolPointer()
        {
            manipulationType = ManipulationType.None;
            selectedObjectType = SelectedObjectType.None;
            lastPoint = PointF.Empty;
            resizingHandle = 0;
            imgSize = new Size(320,240);
            mouseDelta = PointF.Empty;
            directZoomTopLeft = new Point(-1, -1);

            SetupHandCursors();
        }
        #endregion
        
        #region AbstractDrawingTool Implementation
        public override AbstractDrawing GetNewDrawing(PointF origin, long timestamp, long averageTimeStampsPerFrame, IImageToViewportTransformer transformer)
        {
            return null;
        }
        #endregion

        #region Public Interface
        /// <summary>
        /// Enable solo mode for a drawing.
        /// The hit tests will only work for this drawing.
        /// This is used for special rendering surfaces like tracking configuration.
        /// </summary>
        public void SetSoloMode(bool isSolo, Guid soloId, bool configureTracking)
        {
            this.isSolo = isSolo;
            this.soloId = soloId;
            this.configureTracking = configureTracking;
        }

        public bool OnMouseDown(Metadata metadata, IImageToViewportTransformer transformer, int activeKeyFrameIndex, PointF mouseCoordinates, long currentTimeStamp, bool allFrames)
        {
            //--------------------------------------------------------------------------------------
            // Change the ManipulationType if we are on a Drawing, Track, etc.
            // When we later pass in the MouseMove function, we will have the right ManipulationType set
            // and we will be able to do the right thing.
            //
            // We give priority to Keyframes Drawings because they can be moved.
            // If a Drawing is under a Trajectory or Chrono, we have to be able to move it around.
            //--------------------------------------------------------------------------------------

            manipulationType = ManipulationType.None;
            metadata.DeselectAll();

            // Store position (descaled: in original image coords).
            lastPoint.X = mouseCoordinates.X;
            lastPoint.Y = mouseCoordinates.Y;
            originPoint = lastPoint;
            originTime = currentTimeStamp;

            if (IsOnDrawing(metadata, activeKeyFrameIndex, mouseCoordinates, currentTimeStamp, allFrames))
                return true;

            if (IsOnTrack(metadata, transformer, mouseCoordinates, currentTimeStamp))
                return true;

            if (IsOnChronometer(metadata, mouseCoordinates, currentTimeStamp))
                return true;

            if (IsOnSingletonDrawing(metadata, mouseCoordinates, currentTimeStamp))
                return true;

            // Moving the whole image (Direct Zoom)
            selectedObjectType = SelectedObjectType.None;
            return false;
        }
        public bool OnMouseMove(Metadata metadata, PointF mouseLocation, Point newDirectZoomTopLeft, Keys modifiers)
        {
            // Note: We work with image coordinates at subpixel accuracy.
            // Note: We only get here if left mouse button is down.

            bool movedObject = true;

            if (this.directZoomTopLeft.X == -1)
            {
                // Initialize the zoom offset.
                this.directZoomTopLeft = new Point(newDirectZoomTopLeft.X, newDirectZoomTopLeft.Y);
            }

            // Find difference between previous and current position
            float deltaX = (mouseLocation.X - lastPoint.X) - (newDirectZoomTopLeft.X - directZoomTopLeft.X);
            float deltaY = (mouseLocation.Y - lastPoint.Y) - (newDirectZoomTopLeft.Y - directZoomTopLeft.Y);
            mouseDelta = new PointF(deltaX, deltaY);
            mouseDeltaOrigin = new PointF(mouseLocation.X - originPoint.X, mouseLocation.Y - originPoint.Y);
            
            lastPoint.X = mouseLocation.X;
            lastPoint.Y = mouseLocation.Y;
            
            directZoomTopLeft = new Point(newDirectZoomTopLeft.X, newDirectZoomTopLeft.Y);

            if (deltaX == 0 && deltaY == 0)
                return false;

            // Temporary switch the track to configuration mode if it is being manipulated 
            // from a dedicated configuration viewport.
            bool isConfiguringTrack = false;
            if (isSolo && configureTracking && metadata.HitDrawing != null && soloId == metadata.HitDrawing.Id && metadata.HitDrawing is DrawingTrack)
            {
                DrawingTrack track = metadata.HitDrawing as DrawingTrack;
                track.SetConfiguring(true);
                isConfiguringTrack = true;
            }

            switch (manipulationType)
            {
                case ManipulationType.Move:
                    {
                        switch (selectedObjectType)
                        {
                            case SelectedObjectType.None:
                                movedObject = false;
                                break;
                            default:
                                if (metadata.HitDrawing != null)
                                {
                                    metadata.HitDrawing.MoveDrawing(deltaX, deltaY, modifiers);
                                    DrawingModified?.Invoke(this, new DrawingEventArgs(metadata.HitDrawing, metadata.HitDrawingOwner.Id, DrawingAction.Moving));
                                }
                                break;
                        }
                    }
                    break;
                case ManipulationType.Resize:
                    {
                        switch (selectedObjectType)
                        {
                            case SelectedObjectType.None:
                                movedObject = false;
                                break;
                            default:
                                if (metadata.HitDrawing != null)
                                {
                                    metadata.HitDrawing.MoveHandle(mouseLocation, resizingHandle, modifiers);
                                    DrawingModified?.Invoke(this, new DrawingEventArgs(metadata.HitDrawing, metadata.HitDrawingOwner.Id, DrawingAction.Resizing));
                                }
                                break;
                        }
                    }
                    break;
                default:
                    movedObject = false;
                    break;
            }


            if (isConfiguringTrack)
            {
                DrawingTrack track = metadata.HitDrawing as DrawingTrack;
                track.SetConfiguring(false);
            }
            
            return movedObject;
        }
        public void OnMouseUp(Metadata metadata)
        {
            if (metadata.HitDrawing != null)
            {
                if (manipulationType == ManipulationType.Move)
                {
                    DrawingModified?.Invoke(this, new DrawingEventArgs(metadata.HitDrawing, metadata.HitDrawingOwner.Id, DrawingAction.Moved));
                }
                else if (manipulationType == ManipulationType.Resize)
                {
                    DrawingModified?.Invoke(this, new DrawingEventArgs(metadata.HitDrawing, metadata.HitDrawingOwner.Id, DrawingAction.Resized));
                }
            }

            manipulationType = ManipulationType.None;
        }
        public void SetImageSize(Size newSize)
        {
            imgSize = newSize;
        }
        public void SetZoomLocation(Point point)
        {
            directZoomTopLeft = point;
        }
        public Cursor GetCursor()
        {
            return manipulationType == ManipulationType.None ? PointerManager.Cursor : cursorHandClose;
        }
        public Cursor GetCursor(int type)
        {
            // 0: Open hand, 1: Closed hand, -1: same as last time.
            
            Cursor cur = PointerManager.Cursor;
            switch(type)
            {
                case -1:
                    cur = lastCursorType == 0 ? PointerManager.Cursor : cursorHandClose;
                    break;
                case 1:
                    cur = cursorHandClose;
                    break;
            }

            return cur;
        }
        #endregion
        
        #region Objects hit testing


        /// <summary>
        /// Test if we hit a drawing of any key frame.
        /// </summary>
        private bool IsOnDrawing(Metadata metadata, int activeKeyFrameIndex, PointF mouseCoordinates, long currentTimeStamp, bool allFrames)
        {
            if (metadata.Keyframes.Count == 0)
                return false;

            bool isOnDrawing = false;

            DistortionHelper distorter = metadata.CalibrationHelper.DistortionHelper;

            if (allFrames && metadata.Keyframes.Count > 0)
            {
                int[] zOrder = metadata.GetKeyframesZOrder(currentTimeStamp);

                for (int i = 0; i < zOrder.Length; i++)
                {
                    isOnDrawing = DrawingHitTest(metadata, zOrder[i], mouseCoordinates, currentTimeStamp, distorter, metadata.ImageTransform);
                    if (isOnDrawing)
                        break;
                }
            }
            else if (activeKeyFrameIndex >= 0)
            {
                isOnDrawing = DrawingHitTest(metadata, activeKeyFrameIndex, mouseCoordinates, metadata[activeKeyFrameIndex].Timestamp, distorter, metadata.ImageTransform);
            }

            // We are about to start a move operation, capture the state for undo/redo.
            if (isOnDrawing)
            {
                HistoryMementoModifyDrawing memento = new HistoryMementoModifyDrawing(metadata, metadata.HitKeyframe.Id, metadata.HitDrawing.Id, metadata.HitDrawing.Name, SerializationFilter.Core);
                metadata.HistoryStack.PushNewCommand(memento);
            }

            return isOnDrawing;
        }


        /// <summary>
        /// Test if we hit a drawing of a key frame.
        /// </summary>
        private bool DrawingHitTest(Metadata metadata, int keyFrameIndex, PointF mouseCoordinates, long currentTimeStamp, DistortionHelper distorter, ImageTransform transformer)
        {
            bool isOnDrawing = false;
            int hitResult = -1;
            int currentDrawing = 0;

            Keyframe kf = metadata.Keyframes[keyFrameIndex];
            while (hitResult < 0 && currentDrawing < kf.Drawings.Count)
            {
                // Bail out if not the solo drawing.
                if (isSolo && soloId != kf.Drawings[currentDrawing].Id)
                {
                    currentDrawing++;
                    continue;
                }

                hitResult = kf.Drawings[currentDrawing].HitTest(mouseCoordinates, currentTimeStamp, distorter, transformer);

                if (hitResult < 0)
                {
                    if (isSolo && soloId == kf.Drawings[currentDrawing].Id)
                    {
                        // We are soloing this drawing but got no hit, no need to test further.
                        break;
                    }
                    else
                    {
                        currentDrawing++;
                        continue;
                    }
                }
                
                isOnDrawing = true;
                selectedObjectType = SelectedObjectType.Drawing;
                metadata.SelectDrawing(kf.Drawings[currentDrawing], kf);
                metadata.SelectKeyframe(kf);

                if (hitResult > 0)
                {
                    manipulationType = ManipulationType.Resize;
                    resizingHandle = hitResult;
                }
                else
                {
                    manipulationType = ManipulationType.Move;
                }

                // We got a hit, no need to test further.
                break;
            }

            return isOnDrawing;
        }
        private bool IsOnSingletonDrawing(Metadata metadata, PointF mouseCoordinates, long currentTimestamp)
        {
            // Test if we hit a singleton drawing.
            
            bool isOnDrawing = false;
            foreach (AbstractDrawing drawing in metadata.SingletonDrawingsManager.Drawings)
            {
                int hitResult = drawing.HitTest(mouseCoordinates, currentTimestamp, metadata.CalibrationHelper.DistortionHelper, metadata.ImageTransform);
                if (hitResult < 0)
                    continue;

                isOnDrawing = true;
                selectedObjectType = SelectedObjectType.SingletonDrawing;
                metadata.SelectDrawing(drawing, metadata.SingletonDrawingsManager);

                if (hitResult > 0)
                {
                    manipulationType = ManipulationType.Resize;
                    resizingHandle = hitResult;
                }
                else
                {
                    manipulationType = ManipulationType.Move;
                }

                break;
            }

            // We are about to start a move operation, capture the state for undo/redo.
            if (isOnDrawing)
            {
                var managerId = metadata.HitDrawingOwner.Id;
                HistoryMementoModifyDrawing memento = new HistoryMementoModifyDrawing(metadata, managerId, metadata.HitDrawing.Id, metadata.HitDrawing.Name, SerializationFilter.Core);
                metadata.HistoryStack.PushNewCommand(memento);
            }

            return isOnDrawing;
        }
        private bool IsOnChronometer(Metadata metadata, PointF point, long currentTimestamp)
        {
            bool isOnDrawing = false;
            foreach (AbstractDrawing drawing in metadata.ChronoManager.Drawings)
            {
                int hitResult = drawing.HitTest(point, currentTimestamp, metadata.CalibrationHelper.DistortionHelper, metadata.ImageTransform);
                if (hitResult < 0)
                    continue;

                isOnDrawing = true;
                selectedObjectType = SelectedObjectType.Chrono;
                metadata.SelectDrawing(drawing, metadata.ChronoManager);

                if (hitResult > 0)
                {
                    manipulationType = ManipulationType.Resize;
                    resizingHandle = hitResult;
                }
                else
                {
                    manipulationType = ManipulationType.Move;
                }

                break;
            }

            // We are about to start a move operation, capture the state for undo/redo.
            // Save Core and Style, as we may change the font size by dragging the corner.
            if (isOnDrawing)
            {
                SerializationFilter filter = SerializationFilter.Core | SerializationFilter.Style;
                HistoryMementoModifyDrawing memento = new HistoryMementoModifyDrawing(metadata, metadata.ChronoManager.Id, metadata.HitDrawing.Id, metadata.HitDrawing.Name, filter);
                metadata.HistoryStack.PushNewCommand(memento);
            }

            return isOnDrawing;
        }
        private bool IsOnTrack(Metadata metadata, IImageToViewportTransformer transformer, PointF mouseCoordinates, long currentTimeStamp)
        {
            // Track have their own special hit test because we need to differenciate the interactive case from the edit case.
            bool isOnDrawing = false;
            foreach (AbstractDrawing drawing in metadata.TrackManager.Drawings)
            {
                DrawingTrack track = drawing as DrawingTrack;
                if (track == null)
                {
                    continue;
                }

                // Bail out if not the solo drawing.
                if (isSolo && soloId != track.Id)
                {
                    continue;
                }

                int hitResult = 0;

                if (isSolo && soloId == track.Id && configureTracking)
                {
                    track.SetConfiguring(true);
                    hitResult = drawing.HitTest(mouseCoordinates, currentTimeStamp, metadata.CalibrationHelper.DistortionHelper, transformer);
                    track.SetConfiguring(false);
                }
                else
                {
                    hitResult = drawing.HitTest(mouseCoordinates, currentTimeStamp, metadata.CalibrationHelper.DistortionHelper, transformer);
                }

                if (hitResult < 0)
                {
                    if (isSolo && soloId == track.Id)
                    {
                        // We are soloing this drawing but got no hit, no need to test further.
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                isOnDrawing = true;
                selectedObjectType = SelectedObjectType.Track;
                metadata.SelectDrawing(drawing, metadata.TrackManager);

                manipulationType = ManipulationType.Move;

                // TODO: document this. Is this for interactive moving along the track?
                if (isSolo && soloId == track.Id && configureTracking)
                {
                    if (hitResult > 1)
                    {
                        manipulationType = ManipulationType.Resize;
                        resizingHandle = hitResult;
                    }
                }
                else if (track.Status == TrackStatus.Interactive)
                {
                    if (hitResult == 0 || hitResult == 1)
                    {
                        manipulationType = ManipulationType.Resize;
                        resizingHandle = hitResult;
                    }
                }

                // We got a hit, no need to test further. 
                break;
            }

            // We are about to start a move operation, capture the state for undo/redo.
            if (isOnDrawing)
            {
                HistoryMementoModifyDrawing memento = new HistoryMementoModifyDrawing(metadata, metadata.TrackManager.Id, metadata.HitDrawing.Id, metadata.HitDrawing.Name, SerializationFilter.Core);
                metadata.HistoryStack.PushNewCommand(memento);
            }

            return isOnDrawing;
        }
        #endregion

        #region Helpers
        private void SetupHandCursors()
        {
            // Closed hand cursor when moving the image while zoomed in.
            Bitmap bmpClose = Properties.Drawings.handclose24b;
            cursorHandClose = new Cursor(bmpClose.GetHicon());

            lastCursorType = 0;
        }
        #endregion
    }

}
