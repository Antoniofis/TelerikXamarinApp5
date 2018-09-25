using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikXamarinApp5.Portable.ViewModels;
using TelerikXamarinApp5.Portable.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikXamarinApp5.Portable
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewEntryPage : ContentPage
	{
		public NewEntryPage ()
		{
			InitializeComponent ();
            BindingContext = new NewEntryViewModel(DependencyService.Get<INavService>());
		}
	}
}