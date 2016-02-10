using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FFCG.G4.IMDB.Yasmin;

namespace FFCG.G4.IMDB.Yasmin.Api.Controllers
{
    public class MoviesController : ApiController
    {
        public class CreateMovie
        {
            public int movieId { get; set; }
            public string movieName { get; set; }
        }
        
        public IEnumerable<Movie> Get()
        {
            return 
        } 



    }
}