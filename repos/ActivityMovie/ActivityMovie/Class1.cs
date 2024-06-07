using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityMovie
{
     class Movie
    {
        private int rating;
        private String title;
        private String genre;

        public Movie(String title, String genre, int rating)
        {
            this.rating = rating;
            this.title = title;
            this.genre = genre;
        }
        public int getRating() { return rating; }
        public String getTitle() { return title; }
        public String getGenre() {  return genre; }

        public String toString()
        {
            return ("Movie Title:\t"+title+"\nMovie Genre:\t"+genre+"\nMovie Rating:\t"+this.rating);
        }
    }
}
