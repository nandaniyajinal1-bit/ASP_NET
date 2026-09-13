using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_net
{
    internal class StudentDetails
    {
 
        class Student
        {
            private string name;
            private string enrolmentNo;
            private int age;
            private string branch;

            public Student(string name, string enrolmentNo, int age, string branch)
            {
                this.name = name;
                this.enrolmentNo = enrolmentNo;
                this.age = age;
                this.branch = branch;
            }


            public void Display()
            {
                Console.WriteLine("\nStudent Details");
                Console.WriteLine("------------------------");
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Enrolment No. : " + enrolmentNo);
                Console.WriteLine("Age           : " + age);
                Console.WriteLine("Branch        : " + branch);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Enrolment No.: ");
                string enrolmentNo = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Branch: ");
                string branch = Console.ReadLine();

                Student s1 = new Student(name, enrolmentNo, age, branch);

                s1.Display();

                Console.ReadLine();
            }
        }
    }


}

