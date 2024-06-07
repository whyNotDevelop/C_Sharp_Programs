using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    internal abstract class BankAccount
    {
        /*
         * NB: Note that there is R8 bank charges for every deposit and withdrawal made. 

         * 1. Create an abstract class, called BankAccount. This class has two abstract methods, deposit () and withdraw (). (5)
        When the method is implemented by the child class will increase the balance.
        When the method is implemented by the child class should decrease the balance by the withdrawal amount.
        NB: Note that there is R8 bank charges for every deposit and withdrawal made.
        */
        protected double balance;
        protected const double charges = 8.0;

        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);

    }
}
