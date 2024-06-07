// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
namespace ActivityMovie
{
    class ActivityMovie
    {
        static void Main(String[] args)
        {
            Movie[] movieList = new Movie[2];
            populateMovieArray(movieList);
            display(movieList);
            searchDuplicateTitle(movieList);
        }
        static void populateMovieArray(Movie[] movieList)
        {
            for(int i = 0; i < movieList.Length; i++)
            {
                Console.Write("Enter Movie Title:\t");
                String title = Console.ReadLine();
                
                Console.Write("Enter Movie Genre:\t");
                String genre = Console.ReadLine();
                
                Console.Write("Enter Movie Rating:\t");
                int rating = int.Parse(Console.ReadLine());
   
                Console.WriteLine();
                movieList[i] = new Movie(title, genre, rating);
            }
        }
        static void display(Movie[] movieList)
        {
            for (int i=0; i<movieList.Length; i++)
            {
                Console.WriteLine(movieList[i].toString());
                Console.WriteLine();
            }
           
        }
        static void searchDuplicateTitle(Movie[] movieList)
        {
            String str1, str2;
            for(int k=0; k<movieList.Length-1; k++)
            {
                for(int i=k+1; i<movieList.Length-1; i++)
                {
                    str1 = movieList[k].getTitle();
                    str2 = movieList[i].getTitle();
                    if (string.Equals(str2,str1, StringComparison.OrdinalIgnoreCase))
                    {
                     Console.WriteLine("Movie Title" + movieList[i].getTitle()+" is a duplicate");
                     break;
                    }
                   
                }
            }
            Console.WriteLine("No movie title duplicate found!");
        }

    }
}
