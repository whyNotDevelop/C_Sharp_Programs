
namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Initialize two data structures to keep track of books and members both represented as lists. The system
               features two functions (You must create these functions): add_book and add_member. The add_book
               function takes three parameters (book_id, title, author, status) and appends a new book dictionary to
               the books list. The add_member function, on the other hand, requires two parameters (member_id,
               name) and appends a new member dictionary to the members list. Each member dictionary includes an
               empty list for borrowed_books to track the IDs of books each member has borrowed.*/
            Console.WriteLine("Enter number of book you want to record: ");
            int num = int.Parse(Console.ReadLine());
            Books[] booksList = new Books[num];
            poputeBook(booksList);
            diplayInfo(booksList);
            isLatest(booksList);
            Console.Read();

        }
        static void poputeBook(Books[] bookList)
        {
            int Count=bookList.Length;
            for(int i=0; i<Count; i++)
            {
                Console.WriteLine("Enter book Title: ");
                String title = Console.ReadLine();
                Console.WriteLine("Enter the author:"); 
                String author= Console.ReadLine();
                Console.WriteLine("Enter book ID");
                int book_id =int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book status");
                String status= Console.ReadLine();

                //string title,string author,int book_id, string status
                bookList[i] = new Books(title,author,book_id,status);
                Console.WriteLine();
            }
            
        }
        static void diplayInfo(Books[] bookList)
        {
            int count = bookList.Length;
            for (int i=0; i<count; i++)
            {
                Console.WriteLine(bookList[i].toString());
                Console.WriteLine("____________________________________");  
          
            }
        }
        static void isLatest(Books[] booksList)
        {
            int count = booksList.Length;
            for (int i=0; i<count; i++)
            {
                if (booksList[i].getBook_id() > 2024)
                {
                    Console.WriteLine("This book is recent");
                }
                else
                {
                    Console.WriteLine("This is an old book");
                }
            }
         
        }
    }
}
