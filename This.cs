/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class This
    {
        

        class Student
        {
            private string name;
            private string enrolmentNo;
            private int age;

            public Student(string name, string enrolmentNo, int age)
            {
                this.name = name;
                this.enrolmentNo = enrolmentNo;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine("Name          : " + this.name);
                Console.WriteLine("Enrolment No. : " + this.enrolmentNo);
                Console.WriteLine("Age           : " + this.age);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Student student = new Student(
                    "Jinal Nandaniya",
                    "24SOECE11025",
                    20
                );

                Console.WriteLine("Student Details");
                Console.WriteLine("-------------------------");
                student.Display();

                Console.ReadLine();
            }
        }
    }

}*/

