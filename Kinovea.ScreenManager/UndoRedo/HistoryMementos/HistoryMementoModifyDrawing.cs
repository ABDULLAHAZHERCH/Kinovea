﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kinovea.ScreenManager.Languages;
using System.Drawing;
using System.Xml;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace Kinovea.ScreenManager
{
    public class HistoryMementoModifyDrawing : HistoryMemento
    {
        public override string CommandName
        {
            get { return commandName; }
            set { commandName = value; }
        }

        private Metadata metadata;
        private Guid managerId;
        private Guid drawingId;
        private string drawingName;
        private SerializationFilter filter;
        private string commandName;
        private string data;

        /// <summary>
        /// Capture the state of the drawing before a modification.
        /// </summary>
        public HistoryMementoModifyDrawing(Metadata metadata, Guid managerId, Guid drawingId, string drawingName, SerializationFilter filter)
        {
            this.metadata = metadata;
            this.managerId = managerId;
            this.drawingId = drawingId;
            this.drawingName = drawingName;
            this.filter = filter;

            UpdateCommandName(drawingName);

            AbstractDrawingManager manager = metadata.GetDrawingManager(managerId);

            if (manager != null)
                data = DrawingSerializer.SerializeMemento(metadata, manager.GetDrawing(drawingId), filter, false);
        }

        /// <summary>
        /// Restore the backed up state into the drawing.
        /// This also captures the state of the drawing after the modification and return the memento for it, to handle redo.
        /// </summary>
        public override HistoryMemento PerformUndo()
        {
            HistoryMemento redoMemento = new HistoryMementoModifyDrawing(metadata, managerId, drawingId, drawingName, filter);
            DrawingSerializer.DeserializeModifyMemento(managerId, drawingId, data, metadata);
            metadata.ModifiedDrawing(managerId, drawingId);
            return redoMemento;
        }

        public void UpdateCommandName(string name)
        {
            drawingName = name;
            commandName = string.Format("{0} ({1})", ScreenManagerLang.CommandModifyDrawing_FriendlyName, drawingName);
        }

        /// <summary>
        /// Check if the drawing still has the same state as when it was saved in the memento.
        /// This is used to avoid creating unnecessary history commands.
        /// </summary>
        public bool IsSameState()
        {
            AbstractDrawingManager manager = metadata.GetDrawingManager(managerId);
            if (manager == null)
            {
                return false;
            }

            string newData = DrawingSerializer.SerializeMemento(metadata, manager.GetDrawing(drawingId), filter, false);
            return data == newData;
        }

        /// <summary>
        /// Check if another memento was built with the same state as this one.
        /// This is used to avoid creating unnecessary history commands.
        /// </summary>
        public bool IsSameState(HistoryMementoModifyDrawing other)
        {
            return data == other.data;
        }
    }
}