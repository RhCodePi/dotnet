using System;
using System.Collections.Generic;

namespace rhocodepi.movienight
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<Movie> movies = new List<Movie>()
            {
                new Movie("The Batman", "PG-13", 85),
                new Movie("Morbius", "PG-13", 17),
                new Movie("Spider-Man: No Way Home", "PG-13", 93)
            };

            Console.WriteLine("Hit ENTER for a list of superhero movies!");
            Console.ReadKey();

            // MARK: Result
            foreach(Movie movie in movies)
            {
                Console.WriteLine(movie.ToString() + "\n");
            }

            Console.ReadKey();
        }
    }
}