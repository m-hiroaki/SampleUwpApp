using SampleUwpApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUwpApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _count = 0;

        private string _errorMsg = "No Error";

        public event PropertyChangedEventHandler PropertyChanged;

        public string ErrorMsg
        { 
            get => _errorMsg;
            set
            { 
                _errorMsg = value;
                this.OnPropertyChanged(nameof(ErrorMsg));
            }
        }


        public MainPageViewModel()
        {

        }


        public void ButtonClick()
        {
            PrinterStatus printerStatus = new PrinterStatus();

            ErrorMsg = printerStatus.GetErrorMsg(_count++);
        }

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
