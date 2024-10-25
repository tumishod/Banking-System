using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Program
    {
        static void Main(string[] args, string v)
        {
            List<Account> allacounts = new List<Account>();
            {
                new Current("Susan", "Doe", "627856", 26, 1000);
                new Current("James", "Doe", "627846", 26, 1000);
                new Savings("Susan", "Doe", "627846", 26, 500);

            };

            ServiceChargeHandler serviceChargeHandler = new ServiceChargeHandler();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Transfer Funds");
                Console.WriteLine("2. Deduct Servicer Charge");
                Console.WriteLine("3. Exit");

                string pick = Console.ReadLine();

                switch (pick)
                {
                    case "1":
                        Console.WriteLine("Enter source account number:");
                        string sourceAccNum = Console.ReadLine();
                        Console.WriteLine("Enter target account number:");
                        string targetAccNum = Console.ReadLine();
                        Console.WriteLine("Enter amount to transfer:");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        Account sourceAccount = allaccounts.Find(a => a.AccountNumber == sourceAccNum);
                        Account targetAccount = allaccounts.Find(a => a.AccountNumber == targetAccNum);

                        if (sourceAccount != null && targetAccount != null)
                        {
                            sourceAccount.Transfer(amount, targetAccount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Deducting service charges for all accounts...");
                        foreach (var account in allaccounts)
                        {
                            serviceChargeHandler.Charge(account);
                        }
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }  
            }
        }
    }
}
