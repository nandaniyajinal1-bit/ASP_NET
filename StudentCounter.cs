using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class StudentCounter
    {
 
        class Student
        {
            private string name;
            private string enrolmentNo;

            public static int StudentCount = 0;

            public Student(string name, string enrolmentNo)
            {
                this.name = name;
                this.enrolmentNo = enrolmentNo;
                StudentCount++;
            }

            public void Display()
            {
                Console.WriteLine("Enrolment No.: " + enrolmentNo);
                Console.WriteLine("Name         : " + name);
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Student s1 = new Student("Jinal Nandaniya", "24SOECE11025");
                Student s2 = new Student("Mital Ahir", "24SOECE11033");
                Student s3 = new Student("Parul", "25SOEIT13028");
                Student s4 = new Student("Dhami Shah", "25SOEIT13029");
                Student s5 = new Student("Radhu Patel", "25SOEIT13030");

                s1.Display();
                Console.WriteLine();

                s2.Display();
                Console.WriteLine();

                s3.Display();
                Console.WriteLine();

                s4.Display();
                Console.WriteLine();

                s5.Display();
                Console.WriteLine();

                Console.WriteLine("Total Number of Students: " + Student.StudentCount);

                Console.ReadLine();
            }
        }
    }


}

