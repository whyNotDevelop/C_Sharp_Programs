using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal class SavingsAccount : BankAccount
    {
        
        public override void deposit(double deposit)
        {
            balance += deposit;
            balance -= charges;
            Console.WriteLine("Successfully deposited: R"+deposit);
        }
        public override void withdraw(double amount)
        {
            
            //check if there are sufficient funds
            if ((amount+charges) <= balance)
            {
                balance -= amount;
                balance -= charges;
                Console.WriteLine("Transaction was successful");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
                Console.WriteLine("Available balance...R"+balance);
            }

        }
    }
}
