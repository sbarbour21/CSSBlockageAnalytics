﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary.Model
{
    public class BlockEntryModel
    {
        public int Id { get; set; }
        public int EngineerId { get; set; }
        public DateTime Time { get; set; }
        public string ServiceRequest { get; set; }
        public SeverityModel Severity { get; set; } = new SeverityModel();
        public BlockStatusModel Status { get; set; } = new BlockStatusModel();

        public BlockEntryModel()
        {

        }

        public BlockEntryModel(string servicerequest, bool isItCrisit, string severityLetterSelection, string blockstatus, string blockReason)
        {
            DateTime timestamp = DateTime.UtcNow;
            int entryId = Id; 
            Time = timestamp;
            ServiceRequest = servicerequest;
            Severity = new SeverityModel(isItCrisit, severityLetterSelection);
            Status = new BlockStatusModel(blockstatus, blockReason);

            Console.WriteLine($"Blockage Entry {entryId} Completed");
            
        }

    }
}