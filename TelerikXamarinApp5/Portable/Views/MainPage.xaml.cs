using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikXamarinApp5.Portable.Models;
using TelerikXamarinApp5.Portable.ViewModels;
using TelerikXamarinApp5.Portable.Services;
using Xamarin.Forms;

namespace TelerikXamarinApp5.Portable
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel(DependencyService.Get<INavService>());
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }

        private void trips_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            TripLogEntry trip = (TripLogEntry)e.Item;

            Navigation.PushAsync(new DetailPage());

            trips.SelectedItem = null;
        }
    }
}
