using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Customer
    {
        private int id;
        private double balanceOwed;

        public Customer(int id, double balanceOwed) 
        {
            this.balanceOwed = balanceOwed;
            this.id = id;
        }

        public void display()
        {
            Console.WriteLine("Customer#" + id + "\nBalance R" + balanceOwed);
        }
    }
}
