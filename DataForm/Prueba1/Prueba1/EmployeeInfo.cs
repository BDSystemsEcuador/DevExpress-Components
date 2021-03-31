using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Prueba1
{
    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public Department Department { get; set; }
    }
    public enum Department { Sales, Support, Shipping, Engineering, HumanResources, Management, IT }
}
