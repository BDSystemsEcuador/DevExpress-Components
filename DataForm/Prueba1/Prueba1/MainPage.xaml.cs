using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DevExpress.XamarinForms.DataForm;

namespace Prueba1
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Gender Gender { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public enum Gender { Female, Male, RatherNotSay }

    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            DevExpress.XamarinForms.DataForm.Initializer.Init();
            dataForm.DataObject = new PersonalInfo();

        }

    }
}
