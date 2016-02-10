using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FFCG.G4.IMDB.Yasmin;
using Newtonsoft.Json;

namespace FFCG.G4.IMDB.Yasmin.Tests
{
    class JsonStorage : IStorage
    {

        public void AddMovie(Movie movie)
        {
            List<Movie> _movies = new List<Movie>();
            string json = JsonConvert.SerializeObject(_movies, Formatting.Indented);
        }
 
        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        System.IO.File. // (@"D:\path.txt", json);
    }
}
