using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class LineApplication
    {
      class Line
        {
            private double length;

            public Line()
            {
                length = 10;
                Console.WriteLine("Object is being created, length = " + length);
            }

            public void setLength(double len)
            {
                length = len;
            }

            public double getLength()
            {
                return length;
            }
        }

        class TestLine
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Line line = new Line();

                Console.WriteLine("Length of line : {0}", line.getLength());

                line.setLength(6);

                Console.WriteLine("Length of line : {0}", line.getLength());

                Console.ReadKey();
            }
        }
    }



}

