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
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name          : JINAL NANDANIYA");
            Console.WriteLine("Enrollment No.: 25SOEIT13026");
            Console.WriteLine();

            Student s1 = new Student("JINAL NANDANIYA", "24SOECE11025", 20, "B-TECH");
            Student s2 = new Student("GARVI", "24SOECE11033", 22, "B-TECH");
            Student s3 = new Student("DHURVI", "24SOEIT11034", 20, "Computer Engineering");
            Student s4 = new Student("KRISHNA", "24SOEIT13029", 22, "B-TECH");
            Student s5 = new Student("KRISHA", "24SOEIT13030", 21, "B-TECH");

            Console.WriteLine("Student 1 Details");
            s1.Display();

            Console.WriteLine("Student 2 Details");
            s2.Display();

            Console.WriteLine("Student 3 Details");
            s3.Display();

            Console.WriteLine("Student 4 Details");
            s4.Display();

            Console.WriteLine("Student 5 Details");
            s5.Display();

            Console.ReadLine();
        }
    }
}
