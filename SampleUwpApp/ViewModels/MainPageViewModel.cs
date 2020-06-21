using SampleUwpApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUwpApp.ViewModels
{
    public class MainPageViewModel
    {
        private int _count = 0;

        public MainPageViewModel()
        {

        }

        public string ButtonClick()
        {
            PrinterStatus printerStatus = new PrinterStatus();

            return printerStatus.GetErrorMsg(_count++);
        }
    }
}
