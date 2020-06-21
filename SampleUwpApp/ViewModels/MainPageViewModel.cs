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

        public MainPageViewModel()
        {

        }

        public string ButtonClick(int count)
        {
            PrinterStatus printerStatus = new PrinterStatus();

            return printerStatus.GetErrorMsg(count);
        }
    }
}
