using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCG.G4.IMDB.Yasmin
{
    public class MovieCollection
    {
        private readonly List<Movie> _movies;
        public IEnumerable<Movie> Movies { get {return _movies;} }

        public MovieCollection()
        {
            _movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            if (!_movies.Contains(movie))
            {
                _movies.Add(movie);
            }
        }

        public List<Movie> GetAllMoviesInCollection()
        {
            return _movies;
        }
    }

} 
