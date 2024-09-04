using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Program
    {
        static List<Movies> movieList = new List<Movies>();
        static void Main(string[] args)
        {
            dataLoad();
            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine($"There are {movieList.Count} movies in the list.");
            askUserInput();



        }

        static void askUserInput() 
        {
            bool moreInput = true;
            bool movieFound = false;
            do 
            {
                Console.WriteLine("What category of movie are you interested in");
                string desiredCategory = Console.ReadLine();
                
                foreach (Movies movie in movieList) 
                {
                    if (movie.movieCategory.ToLower().Contains(desiredCategory.ToLower()))
                    {
                        Console.WriteLine(movie.movieTitle);
                        movieFound = true;
                    }
                }
                if (!movieFound) 
                { 
                    Console.WriteLine("There were no movies that matched this category");
                }

                bool validResponse = false;
                do
                {
                    Console.WriteLine("Would you like to continue? (y/n)");
                    string userResponse = Console.ReadLine().ToLower().Substring(0,1);
                    if( userResponse == "y")
                    {
                        moreInput = true;
                        validResponse = true;
                    }else if(userResponse == "n") 
                    {
                        moreInput = false;
                        validResponse = true;
                    }
                } while (!validResponse);

            } while (moreInput);

        }



        static void dataLoad() 
        {

            movieList.Add(new Movies("Jurassic Park", "Action"));
            movieList.Add(new Movies("Alien", "Horror"));
            movieList.Add(new Movies("The Matrix", "SciFi"));
            movieList.Add(new Movies("Indiana Jones", "Adventure"));
            movieList.Add(new Movies("Superbad", "Comedy"));
            movieList.Add(new Movies("The Shining", "Horror"));
            movieList.Add(new Movies("Toy Story", "Family"));
            movieList.Add(new Movies("The Terminator", "SciFi"));
            movieList.Add(new Movies("The Truman Show", "Drama"));
            movieList.Add(new Movies("The Thing", "Horror"));

        }
    }
}
