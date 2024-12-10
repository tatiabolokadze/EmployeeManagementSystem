using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; private set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(int employeeId)
        {
            Employees.RemoveAll(e => e.Id == employeeId);
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            foreach (var employee in Employees)
            {
                employee.DisplayInfo();
                Console.WriteLine($"Monthly Pay: {employee.CalculatePay():C}");
                Console.WriteLine();
            }
        }

        public decimal CalculateDepartmentPayroll()
        {
            decimal totalPayroll = 0;
            foreach (var employee in Employees)
            {
                totalPayroll += employee.CalculatePay();
            }
            return totalPayroll;
        }
    }
}
