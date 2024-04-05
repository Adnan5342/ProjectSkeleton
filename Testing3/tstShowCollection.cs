using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstShowCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            Assert.IsNotNull(AllShows); 
        }

        [TestMethod]
        public void ShowListOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            List<clsShow> TestList = new List<clsShow>();
            clsShow TestItem = new clsShow();

            TestItem.ShowId = 1;
            TestItem.Title = "Test Title";
            TestItem.Seasons = 3;
            TestItem.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestItem.Description = "This is a test description.";
            TestItem.Genre = "Action";
            TestItem.Rating = 4.5;
            TestItem.Creators = "A person";
            TestItem.StarActors = "Another person";
            TestItem.CoverImage = "/MovieCoverImages/ArrowShowPoster.jpg";

            TestList.Add(TestItem);
            AllShows.ShowList = TestList;

            Assert.AreEqual(AllShows.ShowList, TestList);
        }

        [TestMethod]
        public void ThisShowPropertyOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            clsShow TestShow = new clsShow();

            TestShow.ShowId = 1;
            TestShow.Title = "Test Title";
            TestShow.Seasons = 3;
            TestShow.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestShow.Description = "This is a test description.";
            TestShow.Genre = "Action";
            TestShow.Rating = 4.5;
            TestShow.Creators = "A person";
            TestShow.StarActors = "Another person";
            TestShow.CoverImage = "/MovieCoverImages/ArrowShowPoster.jpg";

            AllShows.ThisShow = TestShow;

            Assert.AreEqual(AllShows.ThisShow, TestShow);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            List<clsShow> TestList = new List<clsShow>();
            clsShow TestItem = new clsShow();

            TestItem.ShowId = 1;
            TestItem.Title = "Test Title";
            TestItem.Seasons = 3;
            TestItem.ReleaseDate = Convert.ToDateTime("07/01/2002");
            TestItem.Description = "This is a test description.";
            TestItem.Genre = "Action";
            TestItem.Rating = 4.5;
            TestItem.Creators = "A person";
            TestItem.StarActors = "Another person";
            TestItem.CoverImage = "/MovieCoverImages/ArrowShowPoster.jpg";

            TestList.Add(TestItem);
            AllShows.ShowList = TestList;

            Assert.AreEqual(AllShows.Count, TestList.Count);
        }

    }
}
