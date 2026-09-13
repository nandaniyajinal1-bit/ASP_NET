using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASP_NET
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        public void NextSecond()
        {
            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hour++;

                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }


        public void Display()
        {
            Console.WriteLine(hour.ToString("D2") + ":" +
            min.ToString("D2") + ":" +
            sec.ToString("D2"));
        }


        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return min;
        }

        public int getSeconds()
        {
            return sec;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name          : jinal nandaniya");
            Console.WriteLine("Enrollment No.: 24SOECE11025");
            Console.WriteLine();

            Clock c1 = new Clock();
            Console.WriteLine("Default Time:");
            c1.Display();


            Clock c2 = new Clock(10, 25, 59);
            Console.WriteLine("\nParameterized Time:");
            c2.Display();


            c2.NextSecond();
            Console.WriteLine("\nAfter Next Second:");
            c2.Display();


            Console.WriteLine("\nHour  : " + c2.getHour());
            Console.WriteLine("Minute  : " + c2.getMinute());
            Console.WriteLine("Second  : " + c2.getSeconds());

            Console.ReadLine();
        }
    }
}


