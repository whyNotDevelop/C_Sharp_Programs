namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBook textBook = new TextBook(2, "Information Systems", 1200);
            Console.WriteLine(textBook.GetTitle());
        }
    }
    /* Create a class named Book that contains data fields for the title and number of pages.
    Include get and set methods for these fields. Next, create a subclass named Textbook,
    which contains an additional field that holds a grade level for the Textbook and
    additional methods to get and set the grade level field. Write an application that
    demonstrates using objects of each class. Save the files as Book.java, Textbook.java,
    and DemoBook.java.*/

   class Book
    {
        private string title;
        private int numOfPages;
        public Book(string title, int numOfPages)
        {
            this.title = title; 
            this.numOfPages = numOfPages;   
        }

        public string GetTitle()
        {
            return title;
        }
        public int GetNumOfPages()
        {
            return numOfPages;
        }
        public void SetNumOfPages(int page)
        {
            numOfPages = page;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }
    }

    /* Create a class named Book that contains data fields for the title and number of pages.
    Include get and set methods for these fields. Next, create a subclass named Textbook,
    which contains an additional field that holds a grade level for the Textbook and
    additional methods to get and set the grade level field. Write an application that
    demonstrates using objects of each class. Save the files as Book.java, Textbook.java,
    and DemoBook.java.*/
    class TextBook : Book
    {
        private int gradeLevel;

        public TextBook(int gradeLevel, string title, int numOfPages) : base(title, numOfPages)
        {
            this.gradeLevel = gradeLevel;
        }
        public int GetGradeLevel()
        {
            return gradeLevel;  
        }
        public void SetGradeLevel(int gradeLevel)
        {
            this.gradeLevel = gradeLevel;
        }
    }
}