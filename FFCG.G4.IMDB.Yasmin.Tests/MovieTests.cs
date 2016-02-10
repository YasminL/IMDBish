using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FFCG.G4.IMDB.Yasmin;

namespace FFCG.G4.IMDB.Yasmin.Tests
{
    [TestFixture]
    class MovieTests
    {
        private Movie _movie;

        private const int MovieId = 1;
        private const string MovieName = "Harry Potthead";

        [SetUp]
        public void SetUp()
        {
            _movie = new Movie(MovieId, MovieName);
        }

        [Test]
        public void Movie_Is_Added_With_An_Id()
        {
            var actual = _movie.MovieId;
            var expected = MovieId;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Movie_Is_Added_With_A_Name()
        {
            var actual = _movie.MovieName;
            var expected = MovieName;
            Assert.AreEqual(actual, expected);
        }
    }
}
