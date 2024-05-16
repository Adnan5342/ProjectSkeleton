using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstMessage
    {
        string Message = "Test message";
        string DatePosted = DateTime.Now.Date.ToString();

        [TestMethod]
        public void MessageMinMinusOne()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string Message = "aaaa";
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MessageMin()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string Message = "aaaaa";
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MessageMid()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string Message = "";
            Message = Message.PadRight(75, 'a');
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MessageMax()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string Message = "";
            Message = Message.PadRight(150, 'a');
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MessageMaxPlusOne()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string Message = "";
            Message = Message.PadRight(151, 'a');
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinMinusOne()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DatePosted = TestDate.ToString();
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMin()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePosted = TestDate.ToString();
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinPlusOne()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePosted = TestDate.ToString();
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedInvalidData()
        {
            clsMessage AMessage = new clsMessage();
            String Error = "";
            string DatePosted = "This is not a date.";
            Error = AMessage.Valid(Message, DatePosted);
            Assert.AreNotEqual(Error, "");
        }
    }
}
