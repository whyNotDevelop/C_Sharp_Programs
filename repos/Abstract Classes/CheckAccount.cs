using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal class CheckAccount : BankAccount
    {
        private int transactions;
        
        public override void deposit(double amount)
        {          
            balance += amount;

            if (transactions > 10)
            {
              balance -= charges;
            }
            Console.WriteLine("Successfully deposited...R"+amount);
            transactions += 1;

        }
        public override void withdraw(double amount)
        {                      
            //double amountPlusCharges = amount + 8.0;

            if (transactions < 10)
            {              
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Successfully withdrawn...R" + amount);
                    Console.WriteLine("Available balance...R" + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds... Available balance:R" + balance);
                }
            }
            else 
            {               
                if ((amount+charges) <= balance)
                {
                    balance -= amount;
                    balance -= charges;
                    Console.WriteLine("Successfully withdrawn...R" + amount);
                    Console.WriteLine("Available balance...R" + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds... Available balance:R" + balance);
                }

            }
            transactions += 1;
        }
        public double getBal()
        {
            return balance;
        }

        public void deductMonthlyFee()
        {
            balance -= 200.00;
        }

    }
}
