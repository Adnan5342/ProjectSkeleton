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
    }
}
