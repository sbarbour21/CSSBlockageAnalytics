using System;
using System.Data;

namespace CSSBlockageLibrary
{
    public class BlockStatusModel
    {
        public string BlockStatus { get; set; }
        public string BlockReason { get; set; }

        public BlockStatusModel()
        {

        }

        public BlockStatusModel(string blockstatus, string blockReason)
        {
            switch (blockstatus)
            {
                case "Process":
                    BlockStatus = "Process";
                    ProcessReason(blockReason);
                    break;
                case "Knowledge":
                    BlockStatus = "Knowledge";
                    KnowledgeReason(blockReason);
                    break;
                case "Collaboration":
                    BlockStatus = "Collaboration";
                    CollaborationReason(blockReason);
                    break;
                case "Product":
                    BlockStatus = "Product";
                    ProductReason(blockReason);
                    break;
                default:
                    System.Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        private void ProductReason(string blockReason)
        {
            switch (blockReason)
            {
                case "LSI Outage":
                    BlockReason = "LSI Outage";
                    break;
                case "Waiting on EEE/PG":
                    BlockReason = "Waiting on EEE/PG";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        private void CollaborationReason(string blockReason)
        {
            switch (blockReason)
            {
                case "Collaboration with other Team":
                    BlockReason = "Collaboration with other Team";
                    break;
                case "Waiting on Ava for Response":
                    BlockReason = "Waiting on Ava for Response";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        private void KnowledgeReason(string blockReason)
        {
            switch (blockReason)
            {
                case "No Workflow":
                    BlockReason = "No Workflow";
                    break;
                case "No Training":
                    BlockReason = "No Training";
                    break;
                case "Improper Documentation":
                    BlockReason = "Improper Documentation";
                    break;
                case "No Experience":
                    BlockReason = "No Experience";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        private void ProcessReason(string blockReason)
        {
            switch (blockReason)
            {
                case "Misrouted":
                    BlockReason = "Misrouted";
                    break;
                case "Political":
                    BlockReason = "Political";
                    break;
                case "More Information Needed":
                    BlockReason = "More Information Needed";
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}