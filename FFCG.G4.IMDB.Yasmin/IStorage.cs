using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCG.G4.IMDB.Yasmin
{
    public interface IStorage
    {
        IEnumerable<Movie> GetAll(); 
        void AddMovie(Movie movie);
    }
}
