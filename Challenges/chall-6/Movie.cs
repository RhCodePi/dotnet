using System;
namespace rhocodepi.movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        private string title;
        private string rating;
        private int reviewScore;

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }


        public override string ToString()
        {
            string? output, certifeid = "-certifeid fresh";
            output = (reviewScore>75) ? $"-> {title} \n\t Rated {rating} \n\t %{reviewScore} on RT{certifeid}":
                                         $"-> {title} \n\t Rated {rating} \n\t %{reviewScore} on RT ";  
            return output;
        }
    }
}