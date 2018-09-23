using System;
using System.Collections.Generic;
using System.Text;
using TelerikXamarinApp5.Portable.ViewModels;
using TelerikXamarinApp5.Portable.Models;

namespace TelerikXamarinApp5.Portable.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        public DetailViewModel(TripLogEntry entry)
        {
            Entry = entry;               
        }

        TripLogEntry _tripLog;

        public TripLogEntry Entry
        {
            get { return _tripLog; }

            set { _tripLog = value; OnPropertyChanged(); }

        }


    }
}
