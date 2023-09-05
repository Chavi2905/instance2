using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace instance2
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount:F2} into account {AccountNumber}.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount:F2} from account {AccountNumber}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account1 = new BankAccount();

            
            Console.Write("Enter Account Number: ");
            account1.AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            account1.AccountHolderName = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            account1.Balance = decimal.Parse(Console.ReadLine());

           
            Console.WriteLine("\nAccount Details:");
            account1.DisplayAccountDetails();

            
            Console.Write("\nEnter deposit amount: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account1.Deposit(depositAmount);

            Console.Write("Enter withdrawal amount: ");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            account1.Withdraw(withdrawalAmount);

            
            Console.WriteLine("\nUpdated Account Details:");
            account1.DisplayAccountDetails();
        }
    }
    
}
