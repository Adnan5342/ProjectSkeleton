using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstMovie
    {
        //good test data 
        string Title = "Test title";
        string Runtime = TimeSpan.Parse("1:30").ToString();
        string ReleaseDate = Convert.ToDateTime("07/01/2002").ToString();
        string Description = "A very exciting movie!";
        string Genre = "Action";
        string Rating = 4.5.ToString();
        string Directors = "John Smith";
        string Writers = "Smith John";
        String StarActors = "Tom Holland";
        string CoverImage = "/MovieCoverImages/UnchartedMoviePoster.jpg";

        [TestMethod]
        public void InstanceOK()
        {
            clsMovie AMovie = new clsMovie();
            Assert.IsNotNull(AMovie);
        }

        [TestMethod]
        public void MovieIdPropertyOK()
        {
            clsMovie AMovie = new clsMovie();
            Int32 TestData = 21;
            AMovie.MovieId = TestData;
            Assert.AreEqual(AMovie.MovieId, TestData); 
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Test title";
            AMovie.Title = TestData;
            Assert.AreEqual(AMovie.Title, TestData);
        }

        [TestMethod]
        public void RuntimePropertyOK()
        {
            clsMovie AMovie = new clsMovie();
            TimeSpan TestData = TimeSpan.Parse("1:30");
            AMovie.Runtime = TestData;
            Assert.AreEqual(AMovie.Runtime, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            clsMovie AMovie = new clsMovie();
            DateTime TestData = Convert.ToDateTime("07/01/2002");
            AMovie.ReleaseDate = TestData;
            Assert.AreEqual(AMovie.ReleaseDate, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "A very exciting movie!";
            AMovie.Description = TestData;
            Assert.AreEqual(AMovie.Description, TestData);
        }

        [TestMethod]
        public void GenreOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Action";
            AMovie.Genre = TestData;
            Assert.AreEqual(AMovie.Genre, TestData);
        }

        [TestMethod]
        public void RatingOK()
        {
            clsMovie AMovie = new clsMovie();
            double TestData = 4.5;
            AMovie.Rating = TestData;
            Assert.AreEqual(AMovie.Rating, TestData);
        }

        [TestMethod]
        public void DirectorsOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "John Smith";
            AMovie.Directors = TestData;
            Assert.AreEqual(AMovie.Directors, TestData);
        }

        [TestMethod]
        public void WritersOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Smith John";
            AMovie.Writers = TestData;
            Assert.AreEqual(AMovie.Writers, TestData);
        }

        [TestMethod]
        public void StarActorsOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Tom Holland";
            AMovie.StarActors = TestData;
            Assert.AreEqual(AMovie.StarActors, TestData);
        }

        [TestMethod]
        public void CoverImageOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "/MovieCoverImages/UnchartedMoviePoster.jpg";
            AMovie.CoverImage = TestData;
            Assert.AreEqual(AMovie.CoverImage, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsMovie AMovie = new clsMovie();
            //boolean stores the validation results
            Boolean Found = false;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestMovieIdFound()
        {
            clsMovie AMovie = new clsMovie();
            //boolean stores the result of the search
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.MovieId != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true; 
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Title != "Jurassic Park")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRuntimeFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Runtime != TimeSpan.Parse("2:07"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.ReleaseDate != Convert.ToDateTime("15/07/1993"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Description != "A pragmatic paleontologist touring an almost complete theme park " +
                "on an island in Central America is tasked with protecting a couple of kids after a power " +
                "failure causes the park's cloned dinosaurs to run loose.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void GenreFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Genre != "Action, Adventure, Sci-fi")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RatingFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Rating != 4.1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DirectorsFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Directors != "Steven Speilberg")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WritersFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.Writers != "Michael Crichton, David Koepp")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StarActorsFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.StarActors != "Sam Niell, Laura Dern, Jeff Goldblum")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CoverImageFound()
        {
            clsMovie AMovie = new clsMovie();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieId = 4;
            Found = AMovie.Find(MovieId);
            if (AMovie.CoverImage != "/MovieCoverImages/JurassicParkMoviePoster.jpg")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsMovie AMovie = new clsMovie();
            //store any error message
            String Error = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors, CoverImage);
            Assert.AreEqual(Error, "");
        }

    }
}
