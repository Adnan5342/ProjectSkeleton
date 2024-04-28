using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstMovieReview
    {

        double Rating = 2.5;
        string Comment = "Test comment.";
        string DatePosted = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Assert.IsNotNull(AMovieReview);
        }

        [TestMethod] 
        public void MovieReviewIdPropertyOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Int32 TestData = 1;
            AMovieReview.MovieReviewId = TestData;
            Assert.AreEqual(AMovieReview.MovieReviewId, TestData);
        }

        [TestMethod]
        public void MovieIdPropertyOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Int32 TestData = 1;
            AMovieReview.MovieId = TestData;
            Assert.AreEqual(AMovieReview.MovieId, TestData);
        }

        [TestMethod]
        public void MemberIdPropertyOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Int32 TestData = 1;
            AMovieReview.MemberId = TestData;
            Assert.AreEqual(AMovieReview.MemberId, TestData);
        }

        [TestMethod]
        public void RatingPropertyOK() 
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            double TestData = 2.5;
            AMovieReview.Rating = TestData;
            Assert.AreEqual(AMovieReview.Rating, TestData);
        }

        [TestMethod]
        public void CommentPropertyOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            string TestData = "A movie review.";
            AMovieReview.Comment = TestData;
            Assert.AreEqual(AMovieReview.Comment, TestData);
        }

        [TestMethod]
        public void DatePostedPropertyOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            DateTime TestData = DateTime.Now.Date;
            AMovieReview.DatePosted = TestData;
            Assert.AreEqual(AMovieReview.DatePosted, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestMovieReviewIdFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.MovieReviewId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMovieIdFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.MovieId != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMemberIdFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.MemberId != 1003)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePostedFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.DatePosted != Convert.ToDateTime("20/04/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRatingFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.Rating != 4.5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCommentFound()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MovieReviewId = 5;
            Found = AMovieReview.Find(MovieReviewId);
            if (AMovieReview.Comment != "Very good movie")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingExtremeMin()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "-15";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinLessOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "-0.1";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingMin()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "0.1";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinPlusOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "0.2";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMid()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxLessOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "4.9";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMax()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "5";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxPlusOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "5.1";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RatingExtremeMax()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "15";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentMin()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "a";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMinPlusOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "aa";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMid()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "";
            Comment = Comment.PadRight(250, 'a');
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMaxLessOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "";
            Comment = Comment.PadRight(499, 'a');
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMax()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "";
            Comment = Comment.PadRight(500, 'a');
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentMaxPlusOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "";
            Comment = Comment.PadRight(501, 'a');
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentExtremeMax()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string Comment = "";
            Comment = Comment.PadRight(1000, 'a');
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedExtremeMin()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePosted = TestDate.ToString();
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinLessOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DatePosted = TestDate.ToString();
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMin()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePosted = TestDate.ToString();
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinPlusOne()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePosted = TestDate.ToString();
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedExtremeMax()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePosted = TestDate.ToString();
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedInvalidData()
        {
            clsMovieReview AMovieReview = new clsMovieReview();
            String Error = "";
            string Rating = "2.5";
            string DatePosted = "This is not a date!";
            Error = AMovieReview.Valid(Rating, Comment, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

    }
}
