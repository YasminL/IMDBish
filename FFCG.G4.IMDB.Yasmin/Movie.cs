using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCG.G4.IMDB.Yasmin
{
    public class Movie
    {
        public int MovieId { get; private set; }
        public string MovieName { get; private set; }

        public Movie(int movieId, string movieName)
        {
            MovieId = movieId;
            MovieName = movieName; 
        }
    }
}
