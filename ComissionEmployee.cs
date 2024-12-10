using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    public class CommissionEmployee : Employee
    {
        public decimal BaseSalary { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal SalesAmount { get; set; }

        public override decimal CalculatePay()
        {
            return BaseSalary + (SalesAmount * CommissionRate); // Total pay including commission
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Base Salary: {BaseSalary:C}, Commission Rate: {CommissionRate:P}, Sales Amount: {SalesAmount:C}");
        }
    }
}
