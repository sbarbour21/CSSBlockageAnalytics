using CSSBlockageLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSSBlockageLibrary
{
    public class BlockEntryConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();
        public static void InitializeConnection(bool database)
        {
            SQLConnection sql = new SQLConnection();
            Connections.Add(sql);
        }
        public static string[] SubBlockTypeSelection(string blockTypeSelection)
        {
            string[] unknown = new string[1];
            string[] processSelection = new string[] { "Misrouted", "Political", "More Information Needed" };
            string[] collabSelection = new string[] { "Collaboration with other Team", "Waiting on AVA for Response" };
            string[] knowledgeSelection = new string[] { "No Workflow", "No Training", "Improper Documentation", "No Experience" };
            string[] productSelection = new string[] { "LSI Outage", "Waiting on EEE/PG" };
            
            if(blockTypeSelection == "Process")
            {
                return processSelection; 
            }

            if (blockTypeSelection == "Knowledge")
            {
                return collabSelection;
            }

            if(blockTypeSelection == "Collaboration")
            {
                return knowledgeSelection;
            }

            if (blockTypeSelection == "Product")
            {
                return productSelection;
            }else
            {
                return unknown;
            }
        }
    }
}
