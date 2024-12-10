using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }

        public override decimal CalculatePay()
        {
            return HourlyRate * HoursWorked; // Total pay based on hours worked
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}");
        }
    }
}
