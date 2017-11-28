using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFodyDemo.ViewModels
{
    class CustomerViewModel
    {
        public Customer SelectedCustomer { get; set; }


        public CustomerViewModel()
        {
            SelectedCustomer = new Customer { FirstName = "Marcin", LastName = "Sulecki" };
        }
    }
}
