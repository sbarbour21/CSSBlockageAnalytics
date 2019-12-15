using CSSBlockageLibrary.DataAccess;
using System.Collections.Generic;
using System.Configuration;
using System.Deployment.Internal;

namespace CSSBlockageLibrary
{
    public class BlockEntryConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();

        public static void InitializeConnection()
        {
            SQLConnection sql = new SQLConnection();
            Connections.Add(sql);
        }

        public static string[] SubBlockTypeSelection(string blockTypeSelection)
        {
            string[] unknown = new string[1];  //null array for error handling
            string[] processSelection = new string[] { "Misrouted", "Political", "More Information Needed" };
            string[] collabSelection = new string[] { "Collaboration with other Team", "Waiting on AVA for Response" };
            string[] knowledgeSelection = new string[] { "No Workflow", "No Training", "Improper Documentation", "No Experience" };
            string[] productSelection = new string[] { "LSI Outage", "Waiting on EEE/PG" };
            string[] customerSelection = new string[] { "Customer Unresponsive", "Await Customer Response" };

            switch (blockTypeSelection)
            {
                case "Process":
                    return processSelection;

                case "Knowledge":
                    return knowledgeSelection;

                case "Product":
                    return productSelection;

                case "Collaboration":
                    return collabSelection;

                case "Customer":
                    return customerSelection;

                default:
                    return unknown;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string BlockStatusSwitch(string blockstatus)
        {
            var blockOutput = "";

            switch (blockstatus)
            {
                case "Process":
                    blockOutput = "Process";
                    return blockOutput;

                case "Knowledge":
                    blockOutput = "Knowledge";
                    return blockOutput;

                case "Collaboration":
                    blockOutput = "Collaboration";
                    return blockOutput;

                case "Product":
                    blockOutput = "Product";
                    return blockOutput;

                case "Customer":
                    blockOutput = "Customer";
                    return blockOutput;

                default:
                    return "Invalid Entry";

            }
        }



        //TODO -- Configure the Reason Method
    }   
}