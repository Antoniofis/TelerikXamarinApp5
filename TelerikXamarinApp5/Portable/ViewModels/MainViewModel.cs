using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TelerikXamarinApp5.Portable.Models;
using TelerikXamarinApp5.Portable.Services;
using Xamarin.Forms;

namespace TelerikXamarinApp5.Portable.ViewModels
{
   public class MainViewModel: BaseViewModel
    {
    
        public MainViewModel(INavService service):base(service)
        {
            LogEntries = new ObservableCollection<TripLogEntry>();

        }

       
        public override async Task Init()
        {
            await LoadEntries();
        }


        private async Task LoadEntries()
        {
            LogEntries.Clear();

            await Task.Factory.StartNew(() =>
            {
                LogEntries.Add(new TripLogEntry
                {
                    Title = "Washington Monument",
                    Notes = "Amazing!",
                    Rating = 3,
                    Date = new DateTime(2017, 2, 5),
                    Latitude = 38.8895,
                    Longitude = -77.0352

                });

                LogEntries.Add(new TripLogEntry
                {
                    Title = "Statue of Liberty",
                    Notes = "Inspiring",
                    Rating = 4,
                    Date = new DateTime(2017, 4, 13),
                    Latitude = 40.6892,
                    Longitude = -74.0444
                });

                LogEntries.Add(new TripLogEntry
                {
                    Title = "Golden Gate Bridge",
                    Notes = "Foggy, but beautiful",
                    Rating = 5,
                    Date = new DateTime(2017, 4, 26),
                    Latitude = 37.8268,
                    Longitude = -122.4798

                });

            });

        }
        ObservableCollection<TripLogEntry> _logEntries;
     
        public ObservableCollection<TripLogEntry> LogEntries
        {
            get { return _logEntries; }

            set { _logEntries = value; OnPropertyChanged(); }

        }
               
                   

    }
}
