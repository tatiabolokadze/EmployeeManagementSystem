# Company Employee Management System

## Objective

The goal of this project is to create a **Company Employee Management System** that utilizes **inheritance** and **polymorphism** to manage different types of employees and calculate their compensation based on their roles and pay structures.

## Features

- **Employee Types**: The system supports three different types of employees:
  - **Salaried Employee**: Employees with a fixed annual salary.
  - **Hourly Employee**: Employees paid hourly based on the number of hours worked.
  - **Commission Employee**: Employees with a base salary and a commission on sales.
  
- **Methods**:
  - `CalculatePay()`: A method to calculate the employee's compensation.
  - `DisplayInfo()`: A method to display the employee's information.

- **Department Management**: The system allows managing departments and their employees, displaying employee details, and calculating department payroll.
  
- **Company Management**: The system allows adding and removing departments and calculating the overall company payroll.

---

## Class Structure

### 1. **Employee Class (Base Class)**

The `Employee` class is the base class for all employee types, containing the common properties and methods.

#### Properties:
- `Id` (int): Unique identifier for the employee.
- `Name` (string): Employee's name.
- `HireDate` (DateTime): The date the employee was hired.

#### Methods:
- `CalculatePay()`: Virtual method to calculate the employee's compensation (overridden by derived classes).
- `DisplayInfo()`: Virtual method to display the employee's information (overridden by derived classes).

---

### 2. **Derived Classes**

#### 2.1 **SalariedEmployee**
- **Properties**:
  - `AnnualSalary` (decimal): The annual salary.
- **Methods**:
  - `CalculatePay()`: Returns the monthly salary (annual salary / 12).
  - `DisplayInfo()`: Displays the employee's name, hire date, and annual salary.

#### 2.2 **HourlyEmployee**
- **Properties**:
  - `HourlyRate` (decimal): The hourly rate.
  - `HoursWorked` (decimal): The number of hours worked.
- **Methods**:
  - `CalculatePay()`: Returns pay as hours worked * hourly rate.
  - `DisplayInfo()`: Displays the employee's name, hire date, hourly rate, and hours worked.

#### 2.3 **CommissionEmployee**
- **Properties**:
  - `BaseSalary` (decimal): The base salary.
  - `CommissionRate` (decimal): The commission rate (between 0 and 1).
  - `SalesAmount` (decimal): The total sales amount.
- **Methods**:
  - `CalculatePay()`: Returns base salary + (sales amount * commission rate).
  - `DisplayInfo()`: Displays the employee's name, hire date, base salary, commission rate, and sales amount.

---

### 3. **Department Class**

The `Department` class manages the employees within a department.

#### Properties:
- `Name` (string): The name of the department.
- `Employees` (List<Employee>): A list of employees in the department.

#### Methods:
- `AddEmployee(Employee employee)`: Adds an employee to the department.
- `RemoveEmployee(int employeeId)`: Removes an employee by their ID.
- `DisplayAllEmployees()`: Displays the information of all employees in the department.
- `CalculateDepartmentPayroll()`: Calculates the total payroll for the department.

---

### 4. **Company Class**

The `Company` class manages multiple departments.

#### Properties:
- `Name` (string): The name of the company.
- `Departments` (List<Department>): A list of departments in the company.

#### Methods:
- `AddDepartment(Department department)`: Adds a department to the company.
- `RemoveDepartment(string departmentName)`: Removes a department by its name.
- `DisplayAllDepartments()`: Displays information about all departments in the company.
- `CalculateTotalPayroll()`: Calculates the total payroll for the company.

---

## How to Use

1. **Create Employees**: Instantiate objects of the `SalariedEmployee`, `HourlyEmployee`, or `CommissionEmployee` classes and set the appropriate properties.
   
2. **Add Employees to Department**: Add the employee objects to a department using the `AddEmployee()` method.

3. **Calculate Payroll**: For each employee, you can calculate the payroll using the `CalculatePay()` method. You can also calculate the total payroll of a department or the company using `CalculateDepartmentPayroll()` and `CalculateTotalPayroll()`.

4. **Display Employee Information**: Use the `DisplayInfo()` method to display detailed information about each employee, including salary or payment details.

---

## Example Code

```csharp
// Create employees
SalariedEmployee salariedEmployee = new SalariedEmployee(1, "John Doe", new DateTime(2020, 1, 1), 60000);
HourlyEmployee hourlyEmployee = new HourlyEmployee(2, "Jane Smith", new DateTime(2021, 5, 15), 25.0m, 40);
CommissionEmployee commissionEmployee = new CommissionEmployee(3, "Alice Johnson", new DateTime(2019, 8, 10), 30000, 0.05m, 50000);

// Display employee information
salariedEmployee.DisplayInfo();
hourlyEmployee.DisplayInfo();
commissionEmployee.DisplayInfo();

// Calculate pay
Console.WriteLine($"Salaried Employee Pay: {salariedEmployee.CalculatePay()}");
Console.WriteLine($"Hourly Employee Pay: {hourlyEmployee.CalculatePay()}");
Console.WriteLine($"Commission Employee Pay: {commissionEmployee.CalculatePay()}");

// Create department and add employees
Department salesDepartment = new Department("Sales");
salesDepartment.AddEmployee(salariedEmployee);
salesDepartment.AddEmployee(hourlyEmployee);
salesDepartment.AddEmployee(commissionEmployee);

// Display all employees in the department
salesDepartment.DisplayAllEmployees();

// Calculate department payroll
Console.WriteLine($"Total Department Payroll: {salesDepartment.CalculateDepartmentPayroll()}");
