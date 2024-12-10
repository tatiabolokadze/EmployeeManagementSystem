using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_employee_management_system
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; private set; } = new List<Department>();

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void RemoveDepartment(string departmentName)
        {
            Departments.RemoveAll(d => d.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAllDepartments()
        {
            Console.WriteLine($"Company: {Name}");
            foreach (var department in Departments)
            {
                Console.WriteLine($"Department: {department.Name}");
            }
        }

        public decimal CalculateTotalPayroll()
        {
            decimal totalPayroll = 0;
            foreach (var department in Departments)
            {
                totalPayroll += department.CalculateDepartmentPayroll();
            }
            return totalPayroll;
        }
    }
}
