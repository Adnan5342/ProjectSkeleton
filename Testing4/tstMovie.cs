using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;
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
        double Rating = 4.5;
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
                Writers, StarActors);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(50, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(99, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(100, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(101, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(300, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeExtremeMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("0:01");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("0:04");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("0:05");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("0:06");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("5:00");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("9:59");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("10:00");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.Parse("10:01");
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            TimeSpan TestRuntime;
            TestRuntime = TimeSpan.FromHours(50);
            string Runtime = TestRuntime.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RuntimeInvalidData()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Runtime = "Must be a valid runtime: ";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("01/01/1800");
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("31/12/1899");
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("01/01/1900");
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("02/01/1900");
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateDateMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("06/06/2000");
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(59);
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(60);
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(61);
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(200);
            string ReleaseDate = TestDate.ToString();
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string ReleaseDate = "Must be a valid date: ";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(500, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(999, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1000, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1001, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1500, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreExtremeMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "aa";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "aaa";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "aaaa";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(26, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(49, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(50, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(51, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(100, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = -0.1;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 0;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 0.1;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 2.5;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 4.9;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 5;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 5.1;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            double Rating = 15;
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingInvalidData()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string invalidRating = "Invalid rating";
            double Rating;
            if (double.TryParse(invalidRating, out Rating))
            {
                Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                    Writers, StarActors);
            }
            else
            {
                Error = "Must be a valid 'rating': ";  
            }
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "aa";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "";
            Directors = Directors.PadRight(199, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "";
            Directors = Directors.PadRight(200, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "";
            Directors = Directors.PadRight(201, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DirectorsExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Directors = "";
            Directors = Directors.PadRight(500, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WritersMinMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WritersMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WritersMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "aa";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WritersMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Writers = Writers.PadRight(100, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WritersMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Writers = Writers.PadRight(199, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WritersMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Writers = Writers.PadRight(200, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WritersMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Writers = Writers.PadRight(201, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WritersExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string Writers = "";
            Writers = Writers.PadRight(500, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMin()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMinPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "a";
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMid()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(100, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMaxMinusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(199, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(200, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMaxPlusOne()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(201, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsExtremeMax()
        {
            clsMovie AMovie = new clsMovie();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(500, 'a');
            Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
                Writers, StarActors);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

    }
}
