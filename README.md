# Company Employee Management System

A C# application designed to manage employees within a company. It supports multiple employee types, including salaried, hourly, and commission-based employees. The system also allows you to manage departments, add employees, and calculate payroll for both individual employees and the entire company.

## Features

- **Employee Types**:
  - **Salaried Employee**: Employees with a fixed annual salary.
  - **Hourly Employee**: Employees with an hourly rate and a set number of hours worked.
  - **Commission Employee**: Employees with a base salary and a commission based on sales.

- **Department Management**:
  - Add, remove, and display employees within a department.
  - Calculate payroll for each department.
  
- **Payroll Calculation**:
  - Calculate the monthly salary for salaried employees.
  - Calculate pay based on hourly rate and hours worked for hourly employees.
  - Calculate pay including base salary and commission for commission employees.
  - Calculate the total payroll for the company.

## Technologies Used

- **C#**: Core programming language.
- **.NET 9.0 SDK**: Framework used to build the application.
- **Console Application**: The application runs through the terminal/command line.

## Project Structure

The project is structured into several core classes:

- **Employee** (Base class): Contains properties and methods common to all employees, including `Id`, `Name`, `HireDate`, and methods for calculating pay and displaying information.
  
- **SalariedEmployee**: Inherits from `Employee`. Represents salaried employees and calculates pay based on their annual salary divided by 12 (monthly salary).
  
- **HourlyEmployee**: Inherits from `Employee`. Represents hourly employees and calculates pay based on their hourly rate and number of hours worked.
  
- **CommissionEmployee**: Inherits from `Employee`. Represents commission employees who have a base salary and receive commissions based on their sales.
  
- **Department**: Represents a department within the company, containing a list of employees. It includes methods to add or remove employees and calculate the department’s total payroll.

- **Company**: Represents the company, which can contain multiple departments. It has methods to manage departments and calculate the company’s total payroll.

## Installation and Setup

### Prerequisites

Ensure that you have the following installed on your machine:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- A C# compatible IDE (e.g., Visual Studio, Visual Studio Code)


## How to Use

### Step-by-Step Guide

#### Starting the Application:
When the application starts, you’ll be prompted to enter the name of the department you want to manage.

#### Adding Employees:
You can add employees to the department by following these prompts:

1. **Enter Employee ID**
2. **Enter Employee Name**
3. **Enter Employee Hire Date**
4. **Choose Employee Type** (Salaried, Hourly, or Commission-based)

For each employee type, you will be prompted to enter specific details:
- For **Salaried** employees: Enter the annual salary.
- For **Hourly** employees: Enter the hourly rate and the number of hours worked.
- For **Commission-based** employees: Enter the base salary, commission rate, and sales amount.

#### Display Employees:
Once employees are added, you can display information about all employees in the department, including their pay for the month.

#### Payroll Calculation:
After adding employees, the system calculates and displays the total payroll for the department and the company.

```bash
Welcome to the Employee Management System!
Enter the name of the department: IT Department

Add a new employee:
Enter Employee ID: 101
Enter Employee Name: John Doe
Enter Hire Date (yyyy-mm-dd): 2023-01-15
Enter Employee Type (1: Salaried, 2: Hourly, 3: Commission): 1
Enter Annual Salary: 60000

Do you want to add another employee? (y/n): y

Add a new employee:
Enter Employee ID: 102
Enter Employee Name: Jane Smith
Enter Hire Date (yyyy-mm-dd): 2022-06-20
Enter Employee Type (1: Salaried, 2: Hourly, 3: Commission): 2
Enter Hourly Rate: 25.00
Enter Hours Worked: 160

Do you want to add another employee? (y/n): n

Department: IT Department
Employee Information:
ID: 101, Name: John Doe, Hire Date: 2023-01-15
Annual Salary: $60,000.00
Monthly Pay: $5,000.00

ID: 102, Name: Jane Smith, Hire Date: 2022-06-20
Hourly Rate: $25.00, Hours Worked: 160
Monthly Pay: $4,000.00

Total Payroll for IT Department: $9,000.00
Total Payroll for Tech Solutions: $9,000.00

