using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    public class SalariedEmployee : Employee
    {
        public decimal AnnualSalary { get; set; }

        public override decimal CalculatePay()
        {
            return AnnualSalary / 12; // Monthly salary
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Annual Salary: {AnnualSalary:C}");
        }
    }
}
