using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUwpApp.Models
{
    public class PrinterStatus : IPrinterStatus
    {
        public PrinterStatus()
        {

        }

        public string GetErrorMsg(int count)
        {
            string str;
            if ((count % 2) == 0)
            {
                str = "No Error";
            }
            else
            {
                str = "DoorOpen";
            }

            return str;
        }
    }
}
