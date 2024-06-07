namespace Local_Newspaper
{
    internal class Subscribers
    {
        static void Main(string[] args)
        {
            /*Subscribers Test Driver
           Write an application named Subscribers that declares an array consisting of 6  NewspaperSubscribers.
           These subscribers can consist of any combination  of weekly, weekday or weekend subscribers. 
           The sequence of objects for which the user will enter data is not known in advance.
           Your application will be menu driven. Using a dialog box, prompt the user to specify 
           the type of Newspaper Subscriber  that must be created (1 for SevenDay Subscriber, 
           2 for Weekday Subscriber, or 3 for  Weekend Subscriber). 
           Thereafter, create the object based on the appropriate subscription type.
           After creation of all objects, display a single dialog box on the screen showing the data for all objects. 
           Data displayed will include the inherited attributes as well as data specific to the child class for each object.
           The toString() method within the child class will override the parent class toString() method. 
           The data for each object will be displayed on a separate line within the same dialog box.
           Save the files as NewspaperSubscriber.java, WeekdaySubscriber.java,
            WeekendSubscriber.java, SevenDaySubscriber.java and Subscribers.java.
           */
            NewspaperSubscriber[] newspaperSubscribers = new NewspaperSubscriber[6];
            populateNewsapaperSubscribers(newspaperSubscribers);
            displaySubscribers(newspaperSubscribers);


        }
        public static void populateNewsapaperSubscribers(NewspaperSubscriber[] newspaperSubscribers)
        {
            int len = newspaperSubscribers.Length;
            int input;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Select 1,2 or 3 to populate NewspaperSubscriber:");
                Console.WriteLine("1.WeekendSubscriber");
                Console.WriteLine("2.SevenDaySubscriber");
                Console.WriteLine("3.WeekdaySubscriber\n");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        newspaperSubscribers[i] = new WeekendSubscriber();

                        break;
                    case 2:
                        newspaperSubscribers[i] = new SevenDaySubscriber();
                        break;
                    case 3:
                        newspaperSubscribers[i] = new WeekdaySubscriber();
                        break;
                    default:
                        break;

                }
            }
        }
        public static void displaySubscribers(NewspaperSubscriber[] newspaperSubscribers)
        {
            int len = newspaperSubscribers.Length;
            for (int k = 0; k < len; k++)
            {
                Console.WriteLine(newspaperSubscribers[k].ToString());
            }

        }

    }
}