using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class Accountcs
    {

        abstract class Account
        {
            protected double amount;

            public Account(double amount)
            {
                this.amount = amount;
            }

            public abstract double CalculateInterest();

            public void Display()
            {
                Console.WriteLine("Amount   : " + amount);
                Console.WriteLine("Interest : " + CalculateInterest());
            }
        }

        class SavingsAccount : Account
        {
            public SavingsAccount(double amount) : base(amount)
            {
            }

            public override double CalculateInterest()
            {
                return amount * 0.04;
            }
        }

        class CurrentAccount : Account
        {
            public CurrentAccount(double amount) : base(amount)
            {
            }

            public override double CalculateInterest()
            {
                return amount * 0.02;
            }
        }

        class FixedDepositAccount : Account
        {
            public FixedDepositAccount(double amount) : base(amount)
            {
            }

            public override double CalculateInterest()
            {
                return amount * 0.07;
            }
        }

        class TestAccount
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : JINAL NANDANIYA");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                Account savings = new SavingsAccount(50000);
                Account current = new CurrentAccount(50000);
                Account fixedDeposit = new FixedDepositAccount(50000);

                Console.WriteLine("Savings Account");
                Console.WriteLine("-------------------------");
                savings.Display();

                Console.WriteLine();

                Console.WriteLine("Current Account");
                Console.WriteLine("-------------------------");
                current.Display();

                Console.WriteLine();

                Console.WriteLine("Fixed Deposit Account");
                Console.WriteLine("-------------------------");
                fixedDeposit.Display();

                Console.ReadLine();
            }
        }
    }


}

