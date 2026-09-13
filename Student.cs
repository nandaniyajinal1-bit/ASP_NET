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
        private string branch;

        public void SetDetails(string n, string e, string b)
        {
            name = n;
            enrollmentNo = e;
            branch = b;
        }

        public void Display()
        {
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Enrollment No.: " + enrollmentNo);
            Console.WriteLine("Branch        : " + branch);
            Console.WriteLine();
        }
    }


    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name          : JINAL NANDANIYA");
            Console.WriteLine("Enrollment No.: 24SOECE11025");
            Console.WriteLine();

            Student student1 = new Student();
            student1.SetDetails("JINAL NANDANIYA", "24SOECE110125", "CE");

            Student student2 = new Student();
            student2.SetDetails("MITAL CHHUCHHAR", "24SEOCE11053", "IT");

            Console.WriteLine("Student 1 Details");
            student1.Display();

            Console.WriteLine("Student 2 Details");
            student2.Display();

            Console.ReadLine();
        }
    }
}



