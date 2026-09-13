using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    class Student
    {
        private string name;
        private string enrollmentNo;
        private int age;
        private string branch;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string EnrollmentNo
        {
            get { return enrollmentNo; } // Fixed: added missing space between return and enrollmentNo
            set { enrollmentNo = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }

        public Student()
        {
            name = "Unknown";
            enrollmentNo = "Not Assigned";
            age = 0;
            branch = "Not Assigned";
        }

        public Student(string n, string e, int a, string b)
        {
            name = n;
            enrollmentNo = e;
            age = a;
            branch = b;
        }

        public void Display()
        {
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Enrollment No.: " + enrollmentNo);
            Console.WriteLine("Age           : " + age);
            Console.WriteLine("Branch        : " + branch);
        }
    }

    class TestStudent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name          : JINAL NANDANIYA");
            Console.WriteLine("Enrollment No.: 24SOECE11025");
            Console.WriteLine();

            Student s1 = new Student();

            s1.Name = "JINAL NANDANIYA";
            s1.EnrollmentNo = "24SOECE11025";
            s1.Age = 20;
            s1.Branch = "Information Technology";

            Console.WriteLine("Student Details (Using Default Constructor)");
            s1.Display();

            Console.WriteLine();

            Student s2 = new Student("MITAL Chhuchhar", "24SOECE11014", 21, "B-Pharm");

            Console.WriteLine("Student Details (Using Parameterized Constructor)");
            s2.Display();

            Console.ReadLine();
        }
    }
}
