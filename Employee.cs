/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
 

        class Employee
        {
            private double salary;

            public string EmployeeId { get; set; }
            public string Name { get; set; }

            public Employee(string employeeId, string name, double salary)
            {
                EmployeeId = employeeId;
                Name = name;
                this.salary = salary;
            }

            public void SetSalary(double amount)
            {
                if (amount > 0)
                {
                    salary = amount;
                }
                else
                {
                    Console.WriteLine("Invalid Salary");
                }
            }

            public double GetSalary()
            {
                return salary;
            }

            public void DisplayEmployee()
            {
                Console.WriteLine("Employee ID : " + EmployeeId);
                Console.WriteLine("Name        : " + Name);
                Console.WriteLine("Salary      : " + GetSalary());
            }
        }

        class Manager : Employee
        {
            private double bonus;

            public Manager(string employeeId, string name, double salary, double bonus)
                : base(employeeId, name, salary)
            {
                this.bonus = bonus;
            }

            public void DisplayManager()
            {
                DisplayEmployee();
                Console.WriteLine("Bonus       : " + bonus);
                Console.WriteLine("Total Salary: " + (GetSalary() + bonus));
            }
        }

        class TestEmployee
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Manager manager = new Manager(
                    "E001",
                    "Jinal Nandaniya",
                    30000,
                    50000
                );

                Console.WriteLine("Employee Details");
                Console.WriteLine("-------------------------");
                manager.DisplayManager();

                Console.WriteLine("\nUpdating Salary...");
                manager.SetSalary(35000);

                Console.WriteLine("\nUpdated Employee Details");
                Console.WriteLine("-------------------------");
                manager.DisplayManager();

                Console.ReadLine();
            }
        }
}*/


