using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelerikXamarinApp5.Portable;
using TelerikXamarinApp5.Portable.Services;
using TelerikXamarinApp5.Portable.ViewModels;
using Xamarin.Forms;

namespace TelerikXamarinApp5.Portable
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var mainPage = new NavigationPage(new MainPage());

            var navService = DependencyService.Get<INavService>() as XamarinFormsNavService;

            navService.XamarinFormsNav = mainPage.Navigation;

            navService.RegisterViewMapping(typeof(MainViewModel), typeof(MainPage));
            navService.RegisterViewMapping(typeof(DetailViewModel), typeof(DetailPage));
            navService.RegisterViewMapping(typeof(NewEntryViewModel), typeof(NewEntryPage));

            MainPage = mainPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
