using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CSSBlockageLibrary
{
    public class SeverityModel
    {
        //User entry from the user
        public string SeverityLetterSelection { get; set; }
        //Checkbox for a CRISIT
        public bool IsitCriSit { get; set; }
        //Array of Severity Letters
        public string[] SeverityLetterArray { get; private set; }

    public string SeverityLetter { get; set; }

        public SeverityModel()
        {

        }

        //Constructor for User entry
        public SeverityModel(bool isItCrisit, string severityLetterSelection)
        {
            isItCrisit = IsitCriSit;
            severityLetterSelection = SeverityLetterSelection;

            int severityLetterOutput = 0;
  
            
            switch (severityLetterSelection)
            {
                case "A":
                    severityLetterOutput = 0;
                    break;
                case "B":
                    severityLetterOutput = 1;
                    break;
                case "B 24/7":
                    severityLetterOutput = 2;
                    break;
                case "C":
                    severityLetterOutput = 3;
                    break;
                
                default:
                    Console.WriteLine("Entry Invalid");
                    break;
            }

            SeverityLetter = SeverityLetterArray[severityLetterOutput];

        }
    }

  

}