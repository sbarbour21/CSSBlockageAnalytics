using System;
using System.Dynamic;

namespace CSSBlockageLibrary.Model
{
    public class BlockEntryModel
    {
        public int Id { get; set; }
        public int EngineerId { get; set; }
        public DateTime Time { get; set; }
        public string ServiceRequest { get; set; }
        public string Severity { get; set; }
        public string CriSit { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }

        public BlockEntryModel()
        {
        }

        public BlockEntryModel(string servicerequest, bool isItCrisit, string severityLetterSelection, string blockstatus, string blockReason)
        {
            DateTime timestamp = DateTime.UtcNow;
            int entryId = Id;
            Time = timestamp;
            ServiceRequest = servicerequest;
            Severity = severityLetterSelection;
            CriSit = BooleanString(isItCrisit);
            Status = blockstatus;
            StatusReason = blockReason;

            

        }

        private string BooleanString(bool isItCrisit)
        {
            if (isItCrisit)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}