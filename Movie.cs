using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace learningCSharp
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public Movie(string aTitle,string aDirector,string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G")
                {
                    rating = value;
                }
                if (value == "PG")
                {
                    return;
                }
                if (value == "PG-13")
                {

                }
                rating = "NR";
            }
        }

    }
}
