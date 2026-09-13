using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class StudentPropertyDemo
    {
  
        class Student
        {
            public string EnrolmentNo { get; set; }
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine("\nStudent Details");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enrolment No.: " + EnrolmentNo);
                Console.WriteLine("Name         : " + Name);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Student student = new Student();

                Console.Write("Enter Enrollment No.: ");
                student.EnrolmentNo = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                student.Name = Console.ReadLine();

                student.Display();

                Console.ReadLine();
            }
        }
    }

}

