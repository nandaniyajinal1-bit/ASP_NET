/*using System;

namespace ASP_NET
{
    class Student
    {
        protected int roll_no;
        protected string name;

        // Constructor
        public Student(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
    }

    class Person : Student
    {
        private int age;

        // Constructor
        public Person(int roll_no, string name, int age)
            : base(roll_no, name)
        {
            this.age = age;
        }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("----------------");
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name   : " + name);
            Console.WriteLine("Age    : " + age);
        }
    }

    class Constructor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Roll No: ");
            int roll_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Create Person object
            Person p = new Person(roll_no, name, age);

            // Display student details
            p.DisplayDetails();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}*/