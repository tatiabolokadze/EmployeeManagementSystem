using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    // საბაზო კლასი
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public virtual decimal CalculatePay()
        {
            return 0; // Default implementation
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Hire Date: {HireDate.ToShortDateString()}");
        }
    }
}
