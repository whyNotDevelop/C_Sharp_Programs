using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
{
    class Driver : Customer
    {
        private double discountRate;

        public Driver(int id, double bal, double rate) : base(id,bal)
        {
         discountRate = rate;
        }

        public  void display()
        {
         base.display();
         Console.WriteLine("Discount rate is " + discountRate);

        }
    }
}
