/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Student_s
    {
  
        class User
        {
            protected string name;
            protected string email;

            public User(string name, string email)
            {
                this.name = name;
                this.email = email;
            }

            public void Display()
            {
                Console.WriteLine("User Information");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Name  : " + name);
                Console.WriteLine("Email : " + email);
            }
        }

        class Student : User
        {
            private string enrolmentNo;
            private string branch;

            public Student(string name, string email, string enrolmentNo, string branch)
                : base(name, email)
            {
                this.enrolmentNo = enrolmentNo;
                this.branch = branch;
            }

            public new void Display()
            {
                Console.WriteLine("Student Information");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Email         : " + email);
                Console.WriteLine("Enrolment No. : " + enrolmentNo);
                Console.WriteLine("Branch        : " + branch);
            }
        }

        class TestUser
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Student student = new Student(
                    "Jinal Nnandaniya",
                    "Jinal@gmail.com",
                    "24SOECE11025",


                    "Computer Engineering"
                );

                student.Display();

                Console.ReadLine();
            }
        }



}   }*/


