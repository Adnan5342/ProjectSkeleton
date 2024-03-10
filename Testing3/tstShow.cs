using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstShow
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShow AShow = new clsShow();
            Assert.IsNotNull(AShow);
        }

        [TestMethod]
        public void ShowIdPropertyOK()
        {
            clsShow AShow = new clsShow();
            Int32 TestData = 21;
            AShow.ShowId = TestData;
            Assert.AreEqual(AShow.ShowId, TestData);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "Test title";
            AShow.Title = TestData;
            Assert.AreEqual(AShow.Title, TestData); 
        }

        [TestMethod]
        public void SeasonsPropertyOK()
        {
            clsShow AShow = new clsShow();
            Int32 TestData = 4;
            AShow.Seasons = TestData;
            Assert.AreEqual(AShow.Seasons, TestData);
        }

        [TestMethod]
        public void ReleaseDatePropertyOK()
        {
            clsShow AShow = new clsShow();
            DateTime TestData = Convert.ToDateTime("07/01/2002");
            AShow.ReleaseDate = TestData;
            Assert.AreEqual(AShow.ReleaseDate, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "This is a description.";
            AShow.Description = TestData;
            Assert.AreEqual(AShow.Description, TestData);
        }

        [TestMethod]
        public void GenrePropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "Adventure";
            AShow.Genre = TestData;
            Assert.AreEqual(AShow.Genre, TestData);
        }

        [TestMethod]
        public void RatingPropertyOK()
        {
            clsShow AShow = new clsShow();
            double TestData = 4.5;
            AShow.Rating = TestData;
            Assert.AreEqual(AShow.Rating, TestData);
        }

        [TestMethod]
        public void CreatorsPropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "Peter Shin";
            AShow.Creators = TestData;
            Assert.AreEqual(AShow.Creators, TestData);
        }

        [TestMethod]
        public void StarActorsPropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "Keanu Reeves";
            AShow.StarActors = TestData;
            Assert.AreEqual(AShow.StarActors, TestData);
        }

        [TestMethod]
        public void CoverImagePropertyOK()
        {
            clsShow AShow = new clsShow();
            string TestData = "/MovieCoverImages/ArrowShowPoster.jpg";
            AShow.CoverImage = TestData;
            Assert.AreEqual(AShow.CoverImage, TestData);
        }
    }
}
