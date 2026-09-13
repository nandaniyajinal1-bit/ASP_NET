/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class PersonalInfo
    {
    
        class Password
        {
            private string password;

            public Password(string password)
            {
                this.password = password;
            }

            public bool Validate()
            {
                return password.Length >= 8 &&
    password.Any(char.IsUpper) &&
    password.Any(char.IsLower) &&
    password.Any(char.IsDigit);
            }

            public void Modify()
            {
                password = password.Trim();
                password = password.Replace(" ", "");
            }

            public void Display()
            {
                Console.WriteLine("Password      : " + password);
                Console.WriteLine("Length        : " + password.Length);
                Console.WriteLine("Uppercase     : " + password.Any(char.IsUpper));
                Console.WriteLine("Lowercase     : " + password.Any(char.IsLower));
                Console.WriteLine("Digit         : " + password.Any(char.IsDigit));
                Console.WriteLine("Valid Password: " + Validate());
            }
        }

        class TestPassword
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Console.Write("Enter Password: ");
                string input = Console.ReadLine();

                Password password = new Password(input);

                password.Modify();

                Console.WriteLine("\nPassword Details");
                Console.WriteLine("-------------------------");
                password.Display();

                Console.ReadLine();
            }
        }
    }

}*/

