using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET
{
    internal class BankAccountDemo
    {

        class BankAccount
        {
            public string AccountNumber { get; set; }
            public string AccountHolder { get; set; }
            public double Balance { get; private set; }

            public BankAccount(string accountNumber, string accountHolder, double balance)
            {
                AccountNumber = accountNumber;
                AccountHolder = accountHolder;
                Balance = balance;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("Amount Deposited: " + amount);
                }
                else
                {
                    Console.WriteLine("Invalid Amount");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine("Amount Withdrawn: " + amount);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance or Invalid Amount");
                }
            }

            public void BalanceEnquiry()
            {
                Console.WriteLine("Account Number : " + AccountNumber);
                Console.WriteLine("Account Holder : " + AccountHolder);
                Console.WriteLine("Balance        : " + Balance);
            }
        }

        class TestBankAccount
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name          : Jinal Nandaniya");
                Console.WriteLine("Enrollment No.: 24SOECE11025");
                Console.WriteLine();

                BankAccount account1 = new BankAccount(
                                "1001",
                                 "Jinal Nandaniya",
                                100000
                            );

                BankAccount account2 = new BankAccount(
                                "1002",
                                "Mital Ahir",
                                15000
                            );

                Console.WriteLine("Account 1");
                Console.WriteLine("-------------------------");
                account1.BalanceEnquiry();

                Console.WriteLine();
                account1.Deposit(5000);
                account1.Withdraw(2000);

                Console.WriteLine("\nAccount 1 After Transactions");
                Console.WriteLine("-------------------------");
                account1.BalanceEnquiry();

                Console.WriteLine("\nAccount 2");
                Console.WriteLine("-------------------------");
                account2.BalanceEnquiry();

                Console.WriteLine();
                account2.Deposit(3000);
                account2.Withdraw(5000);

                Console.WriteLine("\nAccount 2 After Transactions");
                Console.WriteLine("-------------------------");
                account2.BalanceEnquiry();

                Console.ReadLine();
            }
        }
    }

}

