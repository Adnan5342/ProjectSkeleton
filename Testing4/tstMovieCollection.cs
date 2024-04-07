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

        /*[TestMethod]
        public void AddMethodOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            clsMovie TestItem = new clsMovie();
            Int32 PrimaryKey = 0;

            TestItem.MovieId = 4;
            TestItem.Title = "Jurassic Park";
            TestItem.Runtime = TimeSpan.Parse("2:07");
            TestItem.ReleaseDate = Convert.ToDateTime("15/07/1993");
            TestItem.Description = "A pragmatic paleontologist touring an almost complete theme park on " +
                "an island in Central America is tasked with protecting a couple of kids after a power failure " +
                "causes the park's cloned dinosaurs to run loose.";
            TestItem.Genre = "Action, Adventure, Sci-fi";
            TestItem.Rating = 4.1;
            TestItem.Directors = "Steven Speilberg";
            TestItem.Writers = "Michael Crichton, David Koepp";
            TestItem.StarActors = "Sam Niell, Laura Dern, Jeff Goldblum";
            TestItem.CoverImage = "/MovieCoverImages/JurassicParkMoviePoster.jpg";

            AllMovies.ThisMovie = TestItem;
            PrimaryKey = AllMovies.Add();
            TestItem.MovieId = PrimaryKey;
            AllMovies.ThisMovie.Find(PrimaryKey);
            Assert.AreEqual(AllMovies.ThisMovie, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            clsMovie TestItem = new clsMovie();
            Int32 PrimaryKey = 0;

            TestItem.Title = "A new film";
            TestItem.Runtime = TimeSpan.Parse("3:00");
            TestItem.ReleaseDate = Convert.ToDateTime("01/01/2001");
            TestItem.Description = "This is a new description.";
            TestItem.Genre = "Thriller";
            TestItem.Rating = 1.7;
            TestItem.Directors = "Director name";
            TestItem.Writers = "Writer name";
            TestItem.StarActors = "Actor name";
            TestItem.CoverImage = "";

            AllMovies.ThisMovie = TestItem;
            PrimaryKey = AllMovies.Add();
            TestItem.MovieId = PrimaryKey;

            //modify
            TestItem.Title = "A different film";
            TestItem.Runtime = TimeSpan.Parse("1:00");
            TestItem.ReleaseDate = Convert.ToDateTime("23/09/2019");
            TestItem.Description = "I have replaced the description.";
            TestItem.Genre = "Horror";
            TestItem.Rating = 3.0;
            TestItem.Directors = "Steven Connor";
            TestItem.Writers = "Sarah Hikkins";
            TestItem.StarActors = "Zendaya";
            TestItem.CoverImage = "";

            AllMovies.ThisMovie = TestItem;
            AllMovies.Update();
            AllMovies.ThisMovie.Find(PrimaryKey);
            Assert.AreEqual(AllMovies.ThisMovie, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            clsMovie TestItem = new clsMovie();
            Int32 PrimaryKey = 0;

            TestItem.Title = "A new film";
            TestItem.Runtime = TimeSpan.Parse("3:00");
            TestItem.ReleaseDate = Convert.ToDateTime("01/01/2001");
            TestItem.Description = "This is a new description.";
            TestItem.Genre = "Thriller";
            TestItem.Rating = 1.7;
            TestItem.Directors = "Director name";
            TestItem.Writers = "Writer name";
            TestItem.StarActors = "Actor name";
            TestItem.CoverImage = "";

            AllMovies.ThisMovie = TestItem;
            PrimaryKey = AllMovies.Add();
            TestItem.MovieId = PrimaryKey;
            AllMovies.ThisMovie.Find(PrimaryKey);
            AllMovies.Delete();
            Boolean Found = AllMovies.ThisMovie.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }*/

        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            clsMovieCollection FilteredMovies = new clsMovieCollection();
            FilteredMovies.ReportByTitle("");
            Assert.AreEqual(AllMovies.Count, FilteredMovies.Count);
        }

        [TestMethod]
        public void ReportByTitleNoneFound() 
        {
            clsMovieCollection FilteredMovies = new clsMovieCollection();
            FilteredMovies.ReportByTitle("aaaaaaaaa");
            Assert.AreEqual(0, FilteredMovies.Count);
        }

        /*[TestMethod]
        public void ReportByTitleTestDataFound()
        {
            clsMovieCollection FilteredMovies = new clsMovieCollection();
            Boolean OK = true;
            FilteredMovies.ReportByTitle("Jurassic Park");

            if (FilteredMovies.Count == 2)
            {
                if (FilteredMovies.MovieList[0].MovieId != 4)
                {
                    OK = false;
                }
                if (FilteredMovies.MovieList[1].MovieId != 1043)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }*/

    }
}
