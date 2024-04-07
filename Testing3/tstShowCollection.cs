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

        /*[TestMethod]
        public void AddMethodOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            clsShow TestItem = new clsShow();
            Int32 PrimaryKey = 0;

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

            AllShows.ThisShow = TestItem;
            PrimaryKey = AllShows.Add();
            TestItem.ShowId = PrimaryKey;
            AllShows.ThisShow.Find(PrimaryKey);
            Assert.AreEqual(AllShows.ThisShow, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            clsShow TestItem = new clsShow();
            Int32 PrimaryKey = 0;

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

            AllShows.ThisShow = TestItem;
            PrimaryKey = AllShows.Add();
            TestItem.ShowId = PrimaryKey;

            TestItem.ShowId = 2;
            TestItem.Title = "Another Test Title";
            TestItem.Seasons = 5;
            TestItem.ReleaseDate = Convert.ToDateTime("01/01/2001");
            TestItem.Description = "This is another description.";
            TestItem.Genre = "Drama";
            TestItem.Rating = 3;
            TestItem.Creators = "Another person";
            TestItem.StarActors = "Another person, Another person";
            TestItem.CoverImage = "/MovieCoverImages/ArrowShowPoster.jpg";

            AllShows.ThisShow = TestItem;
            AllShows.Update();
            AllShows.ThisShow.Find(PrimaryKey);
            Assert.AreEqual(AllShows.ThisShow, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            clsShow TestItem = new clsShow();
            Int32 PrimaryKey = 0;

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

            AllShows.ThisShow = TestItem;
            PrimaryKey = AllShows.Add();
            TestItem.ShowId = PrimaryKey;
            AllShows.ThisShow.Find(PrimaryKey);
            AllShows.Delete();
            Boolean Found = AllShows.ThisShow.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }*/

        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            clsShowCollection FilteredShows = new clsShowCollection();
            FilteredShows.ReportByTitle("");
            Assert.AreEqual(AllShows.Count, FilteredShows.Count);
        }

        [TestMethod]
        public void ReportByTitleNoneFound()
        {
            clsShowCollection FilteredShows = new clsShowCollection();
            FilteredShows.ReportByTitle("xxxx");
            Assert.AreEqual(0, FilteredShows.Count);
        }

        /*[TestMethod]
        public void ReportByTitleDataFound()
        {
            clsShowCollection FilteredShows = new clsShowCollection();
            Boolean OK = true;
            FilteredShows.ReportByTitle("Random show");

            if (FilteredShows.Count == 2)
            {
                if (FilteredShows.ShowList[0].ShowId != 5)
                {
                    OK = false;
                }
                if (FilteredShows.ShowList[1].ShowId != 27)
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
