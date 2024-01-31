using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstMovieCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            Assert.IsNotNull(AllMovies);
        }

        [TestMethod]
        public void MovieListOK()
        {
            clsMovieCollection AllMovies = new clsMovieCollection();
            //data needs to be a list of objects
            List<clsMovie> TestList = new List<clsMovie>();
            clsMovie TestItem = new clsMovie();

            TestItem.MovieId = 1;
            TestItem.Title = "Test title";
        }

    }
}
