using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class Books
    {
        /*Initialize two data structures to keep track of books and members both represented as lists. The system
        features two functions (You must create these functions): add_book and add_member. The add_book
        function takes three parameters (book_id, title, author, status) and appends a new book dictionary to
        the books list. The add_member function, on the other hand, requires two parameters (member_id,
        name) and appends a new member dictionary to the members list. Each member dictionary includes an
        empty list for borrowed_books to track the IDs of books each member has borrowed.*/
        private int book_id;
        private string title;
        private string author;
        private string status;

        public Books(string title,string author,int book_id, string status) 
        { 
        
            this.title = title;
            this.author = author;
            this.book_id = book_id;
            this.status = status;
        }
        public void setBooks(string title, string author, int book_id, string status)
        {
            this.title = title;
            this.author = author;
            this.title = title;
            this.status= status;
        }
        public void setTitle(string title) {
            this.title = title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void setBook_id(int book_id)
        {
            this.book_id = book_id;
        }
        public int getBook_id()
        {
            return book_id;
        }
        public string getAuthor()
        {
            return author;
        }
        public string getStatus()
        {
            return status;
        }

        public string getTitle() 
        {
            return title; 
        }
        public string toString()
        {
            return ("Book Title:" + title + "\n Author: " + author
                +"\nStatus: "+status+"\nBook id: "+book_id);
        }

    }
}
