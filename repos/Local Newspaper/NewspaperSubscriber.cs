using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Newspaper
{
    internal abstract class NewspaperSubscriber
    {
        /*
        The Daily News is a local newspaper that is distributed throughout KwaZulu Natal. Readers are encouraged to buy 
        the newspaper regularly through special subscription rates. There are 3 subscription packages available. 
        Readers may choose to subscribe to the newspaper for 7 days a week, for the weekdays, or for the weekends only.
        You have been approached to develop an  application for the newspaper to manage their subscribers.  
        Your application will consist of the classes described below:Note that all attributes must be declared as private except for rate.

        NewspaperSubscriber  class- create an abstract class named NewspaperSubscriber with attributes to contain 
        the subscriber’s street address and the subscription rate. Include get and set methods for both these attributes. 
        The set method for the rate is abstract. The setAddress method must prompt the user to enter the subscriber’s address 
        through the use of a dialog box. Create a constructor for the base class. Create a toString() method that concaternates 
         and returns the subscriber’s street address and rate for display.   
         */
        protected string street_address;
        protected double rate;
        

        public abstract void setStreetAddress(string address);
        public abstract void setStreetAddress();
        public abstract void setRate(int rate);
        public abstract double getRate();
        public abstract string getStreetAddress();

    }
}
