using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBlockageLibrary
{
    class EngineerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string name;
        public string FullNamee 
        {
            get { return name; }
            set { name = FirstName + " " + LastName; }
        }
        public string MicrosoftAlias { get; set; }
        private DateTime _time;
        public DateTime Time
        { 
            get { return _time; }
            set { _time = DateTime.UtcNow; }
        }
        public int UserId { get; set; }
        public int BlockDbId { get; set; }

        public EngineerModel()
        {

        }

        public EngineerModel(string firstName, string lastName, string msftAlias)
        {
            FirstName = firstName;
            LastName = lastName;
            MicrosoftAlias = msftAlias;                               
        }
    }
    
}
