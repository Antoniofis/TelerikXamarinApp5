using System;
using System.Collections.Generic;
using System.Text;

namespace TelerikXamarinApp5.Portable.ViewModels
{
   public class NewEntryViewModel: BaseViewModel
    {
        public NewEntryViewModel()
        {
            Date = DateTime.Today;
            Rating = 1;

        }


        string _title;
        public string Title
        {
            get { return _title; }
            set {
                _title = value;
                OnPropertyChanged();
                }
        }
        
        private double _latitude;
        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; OnPropertyChanged(); }
        }

        private double _longitude;
        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; OnPropertyChanged(); }
        }
        
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }


        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; OnPropertyChanged(); }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; OnPropertyChanged(); }
        }


    }
}
