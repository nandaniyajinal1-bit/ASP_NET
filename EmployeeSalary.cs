using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class EmployeeSalary
    {
       class Employee
        {
            protected string employeeId;
            protected string name;
            protected double basicSalary;

            public Employee(string employeeId, string name, double basicSalary)
            {
                this.employeeId = employeeId;
                this.name = name;
                this.basicSalary = basicSalary;
            }

            public virtual double CalculateSalary()
            {
                return basicSalary;
            }

            public virtual void Display()
            {
                Console.WriteLine("Employee ID : " + employeeId);
                Console.WriteLine("Name        : " + name);
                Console.WriteLine("Salary      : " + CalculateSalary());
            }
        }

        class Manager : Employee
        {
            private double bonus;

            public Manager(string employeeId, string name, double basicSalary, double bonus)
                : base(employeeId, name, basicSalary)
            {
                this.bonus = bonus;
            }

            public override double CalculateSalary()
            {
                return basicSalary + bonus;
            }

            public override void Display()
            {
                Console.WriteLine("Category    : Manager");
                base.Display();
                Console.WriteLine("Bonus       : " + bonus);
            }
        }

        class Developer : Employee
        {
            private double allowance;

            public Developer(string employeeId, string name, double basicSalary, double allowance)
                : base(employeeId, name, basicSalary)
            {
                this.allowance = allowance;
            }

            public override double CalculateSalary()
            {
                return basicSalary + allowance;
            }

            public override void Display()
            {
                Console.WriteLine("Category    : Developer");
                base.Display();
                Console.WriteLine("Allowance   : " + allowance);
            }
        }

        class TestEmployee
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Employee manager = new Manager(
                    "E001",
                    "Jinal Nandaniya",
                    50000,
                    10000
                );

                Employee developer = new Developer(
                    "E002",
                    "Mital Ahir",
                    40000,
                    5000
                );

                Console.WriteLine("Manager Details");
                Console.WriteLine("-------------------------");
                manager.Display();

                Console.WriteLine();

                Console.WriteLine("Developer Details");
                Console.WriteLine("-------------------------");
                developer.Display();

                Console.ReadLine();
            }
        }
    }

}

