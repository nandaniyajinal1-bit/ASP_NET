/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public Clock(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public void Display()
        {
            Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }

        public void NextSecond()
        {
            second++;

            if (second == 60)
            {
                second = 0;
                minute++;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;

                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
    }

    class TestClock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name          : Jinal Nandaniya");
            Console.WriteLine("Enrollment No.: 24SOECE11025");
            Console.WriteLine();

            // Fixed: Added space between DateTime and currentTime
            DateTime currentTime = DateTime.Now;

            Clock c1 = new Clock(
                currentTime.Hour,
                currentTime.Minute,
                currentTime.Second
            );

            Console.WriteLine("Current Time:");
            c1.Display();

            c1.NextSecond();

            Console.WriteLine("After One Second:");
            c1.Display();

            Console.ReadLine();
        }
    }
}*/