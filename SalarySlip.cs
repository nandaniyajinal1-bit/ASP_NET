using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class SalarySlip
    {

 
        class Employee
        {
            protected string employeeId;
            protected string name;
            protected double salary;

            public Employee(string employeeId, string name, double salary)
            {
                this.employeeId = employeeId;
                this.name = name;
                this.salary = salary;
            }

            public virtual double CalculateSalary()
            {
                return salary;
            }

            public virtual void GenerateSalarySlip()
            {
                Console.WriteLine("Employee ID : " + employeeId);
                Console.WriteLine("Name        : " + name);
                Console.WriteLine("Salary      : " + CalculateSalary());
            }
        }

        class PermanentEmployee : Employee
        {
            private double bonus;

            public PermanentEmployee(string employeeId, string name, double salary, double bonus)
                : base(employeeId, name, salary)
            {
                this.bonus = bonus;
            }

            public override double CalculateSalary()
            {
                return salary + bonus;
            }

            public override void GenerateSalarySlip()
            {
                Console.WriteLine("Employee Type : Permanent");
                Console.WriteLine("Employee ID   : " + employeeId);
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Basic Salary  : " + salary);
                Console.WriteLine("Bonus         : " + bonus);
                Console.WriteLine("Net Salary    : " + CalculateSalary());
            }
        }

        class ContractEmployee : Employee
        {
            private double workingDays;
            private double dailyRate;

            public ContractEmployee(
                string employeeId,
                string name,
                double workingDays,
                double dailyRate)
                : base(employeeId, name, 0)
            {
                this.workingDays = workingDays;
                this.dailyRate = dailyRate;
            }

            public override double CalculateSalary()
            {
                return workingDays * dailyRate;
            }

            public override void GenerateSalarySlip()
            {
                Console.WriteLine("Employee Type : Contract");
                Console.WriteLine("Employee ID   : " + employeeId);
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Working Days  : " + workingDays);
                Console.WriteLine("Daily Rate    : " + dailyRate);
                Console.WriteLine("Net Salary    : " + CalculateSalary());
            }
        }

        class TestEmployee
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          :Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Employee permanentEmployee = new PermanentEmployee(
                    "E001",
                    "Jinal Nandaniya",
                    500000,
                    100000
                );

                Employee contractEmployee = new ContractEmployee(
                    "E002",
                    "Mital Ahir",
                    25,
                    12000
                );

                Console.WriteLine("Permanent Employee Salary Slip");
                Console.WriteLine("-------------------------------");
                permanentEmployee.GenerateSalarySlip();

                Console.WriteLine();

                Console.WriteLine("Contract Employee Salary Slip");
                Console.WriteLine("-------------------------------");
                contractEmployee.GenerateSalarySlip();

                Console.ReadLine();
            }
        }
    }

}

