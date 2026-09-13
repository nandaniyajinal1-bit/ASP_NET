/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Class1
    {

        class Student
        {

            private int age;
            private string branch;

            public string EnrolmentNo
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public Student(string enrolmentNo, string name, int age, string branch)
            {
                EnrolmentNo = enrolmentNo;
                Name = name;
                this.age = age;
                this.branch = branch;
            }

            public void Display()
            {
                Console.WriteLine("Enrolment No.: " + EnrolmentNo);
                Console.WriteLine("Name          : " + Name);
                Console.WriteLine("Age           : " + age);
                Console.WriteLine("Branch        : " + branch);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("------------------------");

                Student s1 = new Student(
                    "24SOECE11025",
                    "Jinal Nandaniya",
                    20,
                    "Computer Engineering"
                );


                Console.WriteLine("Enrolment No. using Property: " + s1.EnrolmentNo);
                Console.WriteLine("Name using Property          : " + s1.Name);

                Console.WriteLine();

                s1.Display();

                Console.ReadLine();
            }
        }
    }


}*/

