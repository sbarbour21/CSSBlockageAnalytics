using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary
{
    public class BlockEntryModel
    {
        public DateTime Time { get; set; }
        public string ServiceRequest { get; set; }
        public List<SeverityModel> Severity { get; set; } = new List<SeverityModel>();
        public List<BlockStatusModel> Status { get; set; } = new List<BlockStatusModel>();
    }
}
