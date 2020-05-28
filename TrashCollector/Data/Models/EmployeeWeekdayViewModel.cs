using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector.Models;

namespace TrashCollector.Models
{
    public class EmployeeWeekdayViewModel
    { 
        public IEnumerable<Customer> Customers { get; set; }
        public string SelectedDay { get; set; }

    }
}
