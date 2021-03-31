using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DevExpress.XamarinForms.Navigation;

namespace XamarinNavigation
{
    public partial class MainPage : TabPage
    {
        public MainPage()
        {
            DevExpress.XamarinForms.Navigation.Initializer.Init();
            InitializeComponent();
        }
    }
}
