using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BrugApp.Services;
using BrugApp.Views;

namespace BrugApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
