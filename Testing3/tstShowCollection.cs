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

        /*[TestMethod]
        public void ShowListOK()
        {
            clsShowCollection AllShows = new clsShowCollection();
            List
        }*/
    }
}
