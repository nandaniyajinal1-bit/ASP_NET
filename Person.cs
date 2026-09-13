using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Person
    {

        sealed class Student
        {
            public string EnrolmentNo { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

            public Student(string enrolmentNo, string name, int marks)
            {
                EnrolmentNo = enrolmentNo;
                Name = name;
                Marks = marks;
            }

            public void DisplayResult()
            {
                string result;

                if (Marks >= 40)
                    result = "PASS";
                else
                    result = "FAIL";

                Console.WriteLine("Student Result");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enrolment No. : " + EnrolmentNo.ToUpper());
                Console.WriteLine("Name          : " + Name.ToUpper());
                Console.WriteLine("Marks         : " + Marks);
                Console.WriteLine("Result        : " + result);
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
                    "24SOECE11025",
                    "Jinal Nandaniya",
                    92
                );

                student.DisplayResult();

                Console.WriteLine();
                Console.WriteLine("Name Length   : " + student.Name.Length);
                Console.WriteLine("First Name    : " + student.Name.Substring(0, 7));

                Console.ReadLine();
            }
        }
    }


}

