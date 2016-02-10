using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions; 

namespace FFCG.G4.IMDB.Yasmin.Tests
{
    [TestFixture]
    public class MovieCollectionTests
    {
        private MovieCollection _movieCollection;
        private Movie _movie;

        private const int MovieId = 1;
        private const string MovieName = "Harry Potthead";
        
        [SetUp]
        public void SetUp()
        {
            _movie = new Movie(MovieId, MovieName);
            _movieCollection = new MovieCollection();
        }

        [Test]
        public void Add_A_Movie_To_MovieCollection()
        {
            _movieCollection.AddMovie(_movie);
            _movieCollection.Movies.Should().Contain(_movie);
        }

        [Test]
        public void Get_All_Movies_In_MovieCollection()
        {
            _movieCollection.AddMovie(_movie);
            _movieCollection.GetAllMoviesInCollection();
            _movieCollection.Movies.Should().Contain(_movie);
        }

        [Test]
        public void Movie_Should_Not_Be_Added_Twice()
        {
            _movieCollection.AddMovie(_movie); 
            _movieCollection.AddMovie(_movie);
            _movieCollection.Movies.Should().HaveCount(1);

        }
    }

        
    
}
