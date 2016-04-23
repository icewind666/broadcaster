using System;
using BroadcasterTest.Enums;

namespace BroadcasterTest.ModelNS
{
    class ModelEventArgs : EventArgs
    {
        public string Message { get; set; }
        public LogType LogType { get; set; }

        public ModelEventArgs( string message, LogType logType )
        {
            this.Message = message;
            this.LogType = logType;
        }
    }
}
