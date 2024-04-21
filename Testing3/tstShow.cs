using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstShow
    {
        string Title = "Test Title";
        string Description = "This is a test description.";
        string Genre = "Action";
        string Creators = "A person";
        string StarActors = "Another person";
        string CoverImage = "/MovieCoverImages/ArrowShowPoster.jpg";
        string ReleaseDate = Convert.ToDateTime("07/01/2002").ToString();
        int Seasons = 3;
        double Rating = 4.5;

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

        /*[TestMethod]
        public void FindMethodOK()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            Assert.IsTrue(Found);
        }*/

        /*[TestMethod]
        public void TestShowIdFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.ShowId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 4;
            Found = AShow.Find(ShowId);
            if (AShow.Title != "Test Title")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSeasonsFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.Seasons != 8)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.ReleaseDate != Convert.ToDateTime("22/10/2012"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.Description != "Spoiled billionaire playboy Oliver Queen is missing and presumed dead when his yacht is lost at sea. " +
                "He returns five years later a changed man, determined to clean up the city as a hooded vigilante armed with a bow.\r\n\r\n")
             {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    [TestMethod]
    public void TestGenreFound()
    {
        clsShow AShow = new clsShow();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ShowId = 2;
        Found = AShow.Find(ShowId);
        if (AShow.Genre != "Action, Adventure, Crime")
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }
    [TestMethod]
    public void TestRatingFound()
    {
        clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.Rating != 3.75)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        } 

        [TestMethod]
        public void TestCreatorsFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.Creators != "Greg Berlanti, Marc Guggenheim, Andrew Kreisberg")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStarActorsFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.StarActors != "Stephen Amell, Katie Cassidy, David Ramsey\r\n")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCoverImageFound()
        {
            clsShow AShow = new clsShow();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShowId = 2;
            Found = AShow.Find(ShowId);
            if (AShow.CoverImage != string.Empty)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }*/

        [TestMethod]
        public void ValidMethodOK()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "aa";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(50, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(99, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(100, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(101, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Title = "";
            Title = Title.PadRight(300, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(500, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(999, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1000, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1001, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Description = "";
            Description = Description.PadRight(1500, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreExtremeMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "aa";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "aaa";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "aaaa";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(26, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(49, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(50, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(51, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Genre = "";
            Genre = Genre.PadRight(100, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Creators = Creators.PadRight(100, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMaxMinusOne() 
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Creators = Creators.PadRight(199, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Creators = Creators.PadRight(200, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Creators = Creators.PadRight(201, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatorsExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string Creators = "";
            Creators = Creators.PadRight(400, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(100, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(199, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(200, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(201, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StarActorsExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string StarActors = "";
            StarActors = StarActors.PadRight(400, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "a";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            CoverImage = CoverImage.PadRight(50, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            CoverImage = CoverImage.PadRight(99, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            CoverImage = CoverImage.PadRight(100, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            CoverImage = CoverImage.PadRight(101, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CoverImageExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string CoverImage = "";
            CoverImage = CoverImage.PadRight(200, 'a');
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("01/01/1800");
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("31/12/1899");
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("01/01/1900");
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("02/01/1900");
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating); 
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateDateMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = Convert.ToDateTime("06/06/2000");
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(59);
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(60);
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(61);
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(200);
            string ReleaseDate = TestDate.ToString();
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            string ReleaseDate = "Must be a valid date: ";
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = -0.1;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMin()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 0;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 0.1;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMid()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 2.5;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxMinusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 4.9;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 5;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there ISN'T an error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxPlusOne()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 5.1;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingExtremeMax()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = 15;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingInvalidData()
        {
            clsShow AShow = new clsShow();
            String Error = "";
            double Rating = -1;
            Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);
            //test to see that there IS an error
            Assert.AreNotEqual(Error, "");
        }

    }
}
