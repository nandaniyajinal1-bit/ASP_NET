using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Display
    {

        class Customer
        {
            private string name;

            public Customer(string name)
            {
                this.name = name;
            }

            public void FormatName()
            {
                name = name.Trim();
                name = name.Replace("  ", " ");
                name = name.ToLower();
                name = char.ToUpper(name[0]) + name.Substring(1);
                name = name.Insert(0, "Ms. ");
            }

            public void Display()
            {
                Console.WriteLine("Formatted Customer Name: " + name);
            }
        }

        class TestCustomer
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Console.Write("Enter Customer Name: ");
                string input = Console.ReadLine();

                Customer customer = new Customer(input);

                customer.FormatName();
                customer.Display();

                Console.ReadLine();
            }
        }
    }

}

