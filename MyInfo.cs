/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class MyInfo
    {
        class Person
        {
            protected string name;
            protected int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Student : Person
        {
            private string enrolmentNo;
            private string branch;

            public Student(string name, int age, string enrolmentNo, string branch)
                : base(name, age)
            {
                this.enrolmentNo = enrolmentNo;
                this.branch = branch;
            }

            public void Display()
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Age           : " + age);
                Console.WriteLine("Enrolment No. : " + enrolmentNo);
                Console.WriteLine("Branch        : " + branch);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          :Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Student student = new Student(
                    "Jinal Nandaniya",
                    20,
                    "24SOECE11025",
                    "Computer Engineering"
                );

                student.Display();

                Console.ReadLine();
            }
        }
    }


}*/

