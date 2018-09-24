using System;
using System.Collections.Generic;
using System.Text;
using TelerikXamarinApp5.Portable.ViewModels;
using TelerikXamarinApp5.Portable.Models;
using System.Threading.Tasks;
using TelerikXamarinApp5.Portable.Services;

namespace TelerikXamarinApp5.Portable.ViewModels
{
    public class DetailViewModel : BaseViewModel<TripLogEntry>
    {
        public DetailViewModel(INavService service): base(service)
        {
                      
        }
        public override Task Init(TripLogEntry logEntry)
        {
            Entry = logEntry;

            return null;
        }

        TripLogEntry _tripLog;

        public TripLogEntry Entry
        {
            get { return _tripLog; }

            set { _tripLog = value; OnPropertyChanged(); }

        }

      
    }
}
