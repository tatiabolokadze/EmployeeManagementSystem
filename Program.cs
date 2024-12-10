using company_employee_management_system;

// კომპანიის შექმნა

var company = new Company { Name = "Tech Solutions" };

Console.WriteLine("Welcome to the Employee Management System!");


Console.Write("Enter the name of the department: ");
var departmentName = Console.ReadLine();
var department = new Department { Name = departmentName };


while (true)
{
    Console.WriteLine("\nAdd a new employee:");
    Console.Write("Enter Employee ID: ");
    int employeeId = int.Parse(Console.ReadLine());

    Console.Write("Enter Employee Name: ");
    string employeeName = Console.ReadLine();

    Console.Write("Enter Hire Date (yyyy-mm-dd): ");
    DateTime hireDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Enter Employee Type (1: Salaried, 2: Hourly, 3: Commission): ");
    int employeeType = int.Parse(Console.ReadLine());

    Employee employee = null;

    switch (employeeType)
    {
        case 1: // Salaried Employee
            Console.Write("Enter Annual Salary: ");
            decimal annualSalary = decimal.Parse(Console.ReadLine());
            employee = new SalariedEmployee { Id = employeeId, Name = employeeName, HireDate = hireDate, AnnualSalary = annualSalary };
            break;

        case 2: // Hourly Employee
            Console.Write("Enter Hourly Rate: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Hours Worked: ");
            decimal hoursWorked = decimal.Parse(Console.ReadLine());
            employee = new HourlyEmployee { Id = employeeId, Name = employeeName, HireDate = hireDate, HourlyRate = hourlyRate, HoursWorked = hoursWorked };
            break;

        case 3: // Commission Employee
            Console.Write("Enter Base Salary: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Commission Rate (0 to 1): ");
            decimal commissionRate = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Sales Amount: ");
            decimal salesAmount = decimal.Parse(Console.ReadLine());
            employee = new CommissionEmployee { Id = employeeId, Name = employeeName, HireDate = hireDate, BaseSalary = baseSalary, CommissionRate = commissionRate, SalesAmount = salesAmount };
            break;

        default:
            Console.WriteLine("Invalid employee type. Please try again.");
            continue;
    }

    department.AddEmployee(employee);

    Console.Write("Do you want to add another employee? (y/n): ");
    if (Console.ReadLine().ToLower() != "y")
    {
        break;
    }
}

// Add department to company
company.AddDepartment(department);

// Display all departments
company.DisplayAllDepartments();

// Display all employees in the department
department.DisplayAllEmployees();

// Calculate and display total payroll for the company
decimal totalPayroll = company.CalculateTotalPayroll();
Console.WriteLine($"Total Payroll for {company.Name}: {totalPayroll:C}");
