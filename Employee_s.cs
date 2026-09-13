/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Employee_s
    {

        class Employee
        {
            private string name;
            private string employeeId;
            private double basicSalary;
            private double hra;
            private double da;
            private double pf;

            public Employee(string name, string employeeId, double basicSalary)
            {
                this.name = name;
                this.employeeId = employeeId;
                this.basicSalary = basicSalary;
            }

            public void CalculateSalary()
            {
                hra = basicSalary * 0.20;
                da = basicSalary * 0.10;
                pf = basicSalary * 0.12;
            }

            public double GetNetSalary()
            {
                return basicSalary + hra + da - pf;
            }

            public void Display()
            {
                Console.WriteLine("\nEmployee Details");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Employee ID   : " + employeeId);
                Console.WriteLine("Basic Salary  : " + basicSalary);
                Console.WriteLine("HRA           : " + hra);
                Console.WriteLine("DA            : " + da);
                Console.WriteLine("PF            : " + pf);
                Console.WriteLine("Net Salary    : " + GetNetSalary());
            }
        }

        class TestEmployee
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee ID: ");
                string employeeId = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                double basicSalary = Convert.ToDouble(Console.ReadLine());

                Employee emp = new Employee(name, employeeId, basicSalary);

                emp.CalculateSalary();
                emp.Display();

                Console.ReadLine();
            }
        }
    }


}*/

