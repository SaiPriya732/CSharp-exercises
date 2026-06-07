// using System;
// using System.Collections.Generic;

// abstract class Employee
// {
//     public int EmployeeId { get; set; }
//     public string EmployeeName { get; set; }

//     protected double Salary;

//     public Employee(int employeeId, string employeeName, double salary)
//     {
//         EmployeeId = employeeId;
//         EmployeeName = employeeName;
//         Salary = salary;
//     }

//     public abstract double CalculateSalary();

//     public virtual void DisplayInfo()
//     {
//         Console.WriteLine($"Employee: {EmployeeName}");
//     }
// }

// class PermanentEmployee : Employee
// {
//     public PermanentEmployee(int employeeId, string employeeName, double salary)
//         : base(employeeId, employeeName, salary)
//     {
//     }

//     public override double CalculateSalary()
//     {
//         return Salary + (Salary * 0.25);
//     }

//     public override void DisplayInfo()
//     {
//         Console.WriteLine($"Employee: {EmployeeName}");
//         Console.WriteLine("Type: Permanent");
//         Console.WriteLine($"Salary: {CalculateSalary()}");
//     }
// }

// class ContractEmployee : Employee
// {
//     public ContractEmployee(int employeeId, string employeeName, double salary)
//         : base(employeeId, employeeName, salary)
//     {
//     }

//     public override double CalculateSalary()
//     {
//         return Salary;
//     }

//     public override void DisplayInfo()
//     {
//         Console.WriteLine($"Employee: {EmployeeName}");
//         Console.WriteLine("Type: Contract");
//         Console.WriteLine($"Salary: {CalculateSalary()}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>();

//         employees.Add(new PermanentEmployee(
//             101,
//             "Krishna",
//             60000));

//         employees.Add(new ContractEmployee(
//             102,
//             "Ravi",
//             45000));

//         foreach (Employee employee in employees)
//         {
//             employee.DisplayInfo();
//             Console.WriteLine();
//         }
//     }
// }