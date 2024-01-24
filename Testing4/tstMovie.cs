using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstMovie
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsMovie AMovie = new clsMovie();
            Assert.IsNotNull(AMovie);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "The Lost World";
            AMovie.Title = TestData;
            Assert.AreEqual(AMovie.Title, TestData);
        }

        [TestMethod]
        public void RuntimePropertyOK()
        {
            clsMovie AMovie = new clsMovie();
            TimeSpan TestData = new TimeSpan(1, 30, 0);
            AMovie.Runtime = TestData;
            Assert.AreEqual(AMovie.Runtime, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            clsMovie AMovie = new clsMovie();
            DateTime TestData = new DateTime(2002, 1, 7);
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
        public void DirectorOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "John Smith";
            AMovie.Director = TestData;
            Assert.AreEqual(AMovie.Director, TestData);
        }

        [TestMethod]
        public void WriterOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Smith John";
            AMovie.Writer = TestData;
            Assert.AreEqual(AMovie.Writer, TestData);
        }

        [TestMethod]
        public void StarActorOK()
        {
            clsMovie AMovie = new clsMovie();
            string TestData = "Tom Holland";
            AMovie.StarActor= TestData;
            Assert.AreEqual(AMovie.StarActor, TestData);
        }
    }
}
