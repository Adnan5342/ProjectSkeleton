using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstMovieReviewCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            Assert.IsNotNull(AllMovieReviews);
        }

        [TestMethod]
        public void MovieReviewListOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            List<clsMovieReview> TestList = new List<clsMovieReview>();
            clsMovieReview TestItem = new clsMovieReview();

            TestItem.MovieReviewId = 1;
            TestItem.MovieId = 4;
            TestItem.MemberId = 1003;
            TestItem.Rating = 2.5;
            TestItem.Comment = "Test comment.";
            TestItem.DatePosted = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllMovieReviews.MovieReviewList = TestList;

            Assert.AreEqual(AllMovieReviews.MovieReviewList, TestList);
        }

        [TestMethod]
        public void ThisMovieReviewPropertyOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            clsMovieReview TestMovieReview = new clsMovieReview();

            TestMovieReview.MovieReviewId = 1;
            TestMovieReview.MovieId = 4;
            TestMovieReview.MemberId = 1003;
            TestMovieReview.Rating = 2.5;
            TestMovieReview.Comment = "Test comment.";
            TestMovieReview.DatePosted = DateTime.Now.Date;

            AllMovieReviews.ThisMovieReview = TestMovieReview;
            Assert.AreEqual(AllMovieReviews.ThisMovieReview, TestMovieReview);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            List<clsMovieReview> TestList = new List<clsMovieReview>();
            clsMovieReview TestItem = new clsMovieReview();

            TestItem.MovieReviewId = 1;
            TestItem.MovieId = 4;
            TestItem.MemberId = 1003;
            TestItem.Rating = 2.5;
            TestItem.Comment = "Test comment.";
            TestItem.DatePosted = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllMovieReviews.MovieReviewList = TestList;
            Assert.AreEqual(AllMovieReviews.Count, TestList.Count);
        }

        /*[TestMethod]
        public void AddMethodOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            clsMovieReview TestItem = new clsMovieReview();
            Int32 PrimaryKey = 0;

            TestItem.MovieReviewId = 9;
            TestItem.MovieId = 4;
            TestItem.MemberId = 1009;
            TestItem.Rating = 5;
            TestItem.Comment = "Magnificent editing in this film!";
            TestItem.DatePosted = DateTime.Now.Date;

            AllMovieReviews.ThisMovieReview = TestItem;
            PrimaryKey = AllMovieReviews.Add();
            TestItem.MovieReviewId = PrimaryKey;
            AllMovieReviews.ThisMovieReview.Find(PrimaryKey);

            Assert.AreEqual(AllMovieReviews.ThisMovieReview, TestItem);
        }*/

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsMovieReviewCollection AllMovieReviews = new clsMovieReviewCollection();
            clsMovieReview TestItem = new clsMovieReview();
            Int32 PrimaryKey = 0;

            TestItem.MovieReviewId = 1;
            TestItem.MovieId = 1;
            TestItem.MemberId = 1;
            TestItem.Rating = 2.5;
            TestItem.Comment = "Test comment.";
            TestItem.DatePosted = DateTime.Now.Date;

            AllMovieReviews.ThisMovieReview = TestItem;
            PrimaryKey = AllMovieReviews.Add();
            TestItem.MovieReviewId = PrimaryKey;
            AllMovieReviews.ThisMovieReview.Find(PrimaryKey);
            AllMovieReviews.Delete();
            Boolean Found = AllMovieReviews.ThisMovieReview.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

    }
}
