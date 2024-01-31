using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstMovieCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            Assert.IsNotNull(AllMovies);
        }

        [TestMethod]
        public void MovieListOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            //data needs to be a list of objects
            List<clsMovie> TestList = new List<clsMovie>();
            clsMovie TestItem = new clsMovie();

            TestItem.MovieId = 1;
            TestItem.Title = "Test title";
            TestItem.Runtime = TimeSpan.Parse("1:30");
            TestItem.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestItem.Description = "A very exciting movie!";
            TestItem.Genre = "Action";
            TestItem.Rating = 4.5;
            TestItem.Directors = "John Smith";
            TestItem.Writers = "Smith John";
            TestItem.StarActors = "Tom Holland";
            TestItem.CoverImage = "/MovieCoverImages/UnchartedMoviePoster.jpg";

            TestList.Add(TestItem);
            AllMovies.MovieList = TestList;
            Assert.AreEqual(AllMovies.MovieList, TestList);
        }

        [TestMethod]
        public void ThisMoviePropertyOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            clsMovie TestMovie = new clsMovie();

            TestMovie.MovieId = 1;
            TestMovie.Title = "Test title";
            TestMovie.Runtime = TimeSpan.Parse("1:30");
            TestMovie.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestMovie.Description = "A very exciting movie!";
            TestMovie.Genre = "Action";
            TestMovie.Rating = 4.5;
            TestMovie.Directors = "John Smith";
            TestMovie.Writers = "Smith John";
            TestMovie.StarActors = "Tom Holland";
            TestMovie.CoverImage = "/MovieCoverImages/UnchartedMoviePoster.jpg";

            AllMovies.ThisMovie = TestMovie;
            Assert.AreEqual(AllMovies.ThisMovie, TestMovie);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            List<clsMovie> TestList = new List<clsMovie>();
            clsMovie TestItem = new clsMovie();

            TestItem.MovieId = 1;
            TestItem.Title = "Test title";
            TestItem.Runtime = TimeSpan.Parse("1:30");
            TestItem.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestItem.Description = "A very exciting movie!";
            TestItem.Genre = "Action";
            TestItem.Rating = 4.5;
            TestItem.Directors = "John Smith";
            TestItem.Writers = "Smith John";
            TestItem.StarActors = "Tom Holland";
            TestItem.CoverImage = "/MovieCoverImages/UnchartedMoviePoster.jpg";

            TestList.Add(TestItem);
            AllMovies.MovieList = TestList;
            Assert.AreEqual(AllMovies.Count, TestList.Count);
        }

    }
}
