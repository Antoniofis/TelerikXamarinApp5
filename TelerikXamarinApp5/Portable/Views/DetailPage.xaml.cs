using TelerikXamarinApp5.Portable.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using TelerikXamarinApp5.Portable.ViewModels;

namespace TelerikXamarinApp5.Portable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
        DetailViewModel _vm
        {
            get { return BindingContext as DetailViewModel; }

        }


		public DetailPage ()
		{
			InitializeComponent ();

            BindingContext = new DetailViewModel();

            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(_vm.Entry.Latitude, _vm.Entry.Longitude), 
                Distance.FromMiles(.5)));

            map.Pins.Add(new Pin
            {
              Type = PinType.Place,
              Label = _vm.Entry.Title,
              Position = new Position(_vm.Entry.Latitude, _vm.Entry.Longitude)
                            
            });

          
        }
	}
}