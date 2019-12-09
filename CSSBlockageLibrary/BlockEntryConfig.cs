using CSSBlockageLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
