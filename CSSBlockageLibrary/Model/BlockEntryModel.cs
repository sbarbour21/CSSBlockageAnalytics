using System;

namespace CSSBlockageLibrary.Model
{
    public class BlockEntryModel
    {
        public int Id { get; set; }
        public int EngineerId { get; set; }
        public DateTime Time { get; set; }
        public string ServiceRequest { get; set; }
        public string Severity { get; set; }
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
            Status = blockstatus;
            StatusReason = blockReason;


            Console.WriteLine($"Blockage Entry {entryId} Completed");
        }
    }
}