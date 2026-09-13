/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    class Product
    {
        private double billAmount;

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double BillAmount
        {
            get { return billAmount; } // Fixed: added space between return and billAmount
            private set { billAmount = value; }
        }

        public void CalculateBill()
        {
            BillAmount = Price * Quantity;
        }

        public void Display()
        {
            Console.WriteLine("\nProduct Details");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Product Code : " + ProductCode);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price        : " + Price);
            Console.WriteLine("Quantity     : " + Quantity);
            Console.WriteLine("Bill Amount  : " + BillAmount);
        }
    }

    class TestProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name          : Jinal Nandaniya");
            Console.WriteLine("Enrollment No.: 24SOECE11025");
            Console.WriteLine();

            Product product = new Product();

            Console.Write("Enter Product Code: ");
            product.ProductCode = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());

            product.CalculateBill();
            product.Display();

            Console.ReadLine();
        }
    }
}*/