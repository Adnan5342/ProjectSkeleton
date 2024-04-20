using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstMovieReview
    {

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
            Assert.AreEqual(AMovieReview, TestData);
        }

    }
}
