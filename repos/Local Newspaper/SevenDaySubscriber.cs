using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Newspaper
{
    internal class SevenDaySubscriber : NewspaperSubscriber
    {
        /*   
        Create 3 child classes named SevenDaySubscriber, WeekdaySubscriber, and WeekendSubscriber. 
       Each child class has an additional attribute called subType, which is a String, that will store the type of newspaper subscription. 
       Create a setType method that will set the type of subscriber as follows: “Seven Day”, “Weekday”, or“Weekend”. 
       Create a setRate method for each child class that sets the rate as follows: a SevenDaysubscriber pays R18.00 per week for his newspapers, 
       a WeekdaySubscriber pays R15.00 per week, and  a WeekendSubscriber pays R8.00 per week. Use child class constructors 
       to control the setting of the rate. Each child class should include a toString()  method that returns the string “Service type: “ 
       and the subscriptionType as a a single concaternated string.
       The setAddress method must prompt the user to enter the subscriber’s address 
       through the use of a dialog box. Create a constructor for the base class. Create a toString() method that concaternates 
        and returns the subscriber’s street address and rate for display.   
        */
        private string subType;

        public void setType()
        {
            subType = "Seven Day";

        }
        public void setRate()
        {
            this.rate = 18.00;
        }
        public SevenDaySubscriber()
        {
            setRate();
            setStreetAddress();
            setType();
        }
        public override string ToString()
        {
            return ("Service Type: " + subType + "\nPrice: " + rate + "\nStreet Address: " + street_address + "\n");
        }
        public override void setStreetAddress()
        {
            Console.WriteLine("Enter Your Street Address:");
            string st = Console.ReadLine();
            if (st != null)
            {
                setStreetAddress(st);
            }

        }
        public override void setStreetAddress(string address)
        {
            this.street_address = address;
        }
        public override void setRate(int rate)
        {
            this.rate = rate;
        }
        public override double getRate()
        {
            return rate;
        }
        public override string getStreetAddress()
        {
            return street_address;
        }
    }
}
