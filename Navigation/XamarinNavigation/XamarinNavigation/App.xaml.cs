using System;
using Xamarin.Forms;
using DevExpress.XamarinForms.Navigation;

namespace NavigationExample
{
    public class App : Application
    {
        public App()
        {
            TabView tabView = new TabView();
            MainPage = new ContentPage
            {
                Content = tabView,
            };
        }
    }
}