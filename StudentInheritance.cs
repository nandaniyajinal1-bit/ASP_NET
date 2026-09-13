/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class StudentInheritance
    {

        class PersonalInformation
        {
            protected string name;
            protected int age;
            protected string address;
            protected string gender;

            public PersonalInformation(string name, int age, string address, string gender)
            {
                this.name = name;
                this.age = age;
                this.address = address;
                this.gender = gender;
            }

            public void DisplayPersonalInfo()
            {
                Console.WriteLine("Name          : " + name);
                Console.WriteLine("Age           : " + age);
                Console.WriteLine("Address       : " + address);
                Console.WriteLine("Gender        : " + gender);
            }
        }

        class Student : PersonalInformation
        {
            private string enrolmentNo;
            private string branch;
            private string degree;

            public Student(
                string name,
                int age,
                string address,
                string gender,
                string enrolmentNo,
                string branch,
                string degree)
                : base(name, age, address, gender)
            {
                this.enrolmentNo = enrolmentNo;
                this.branch = branch;
                this.degree = degree;
            }

            public void DisplayStudentDetails()
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("-------------------------");
                DisplayPersonalInfo();
                Console.WriteLine("Enrolment No. : " + enrolmentNo);
                Console.WriteLine("Branch        : " + branch);
                Console.WriteLine("Degree        : " + degree);
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
                    20,
                    "Rajkot",
                    "Female",
                    "24SOECE11025",
                    "Computer Engineering",
                    "B.Tech"
                );

                student.DisplayStudentDetails();

                Console.ReadLine();
            }
        }
    }

}*/


