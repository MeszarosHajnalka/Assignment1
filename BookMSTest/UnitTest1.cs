using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;

namespace BookMSTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TitleValidation()
        {
            Book Book = new Book("title", "Author", 11, "aaaaaaaaaaaaa");

            Assert.AreEqual("title", Book.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TitleException() {
            Book Book1 = new Book("t", "Author", 9, "123456789100098787");
            Book1.Title = "t";
        }

        [TestMethod]
        public void PageNumberValidation()
        {
            Book Book = new Book("title", "Author", 11, "aaaaaaaaaaaaa");

            Assert.AreEqual(11, Book.PageNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PageNumberException()
        {
            Book Book2 = new Book("t", "Author", 9, "123456789100098787");
            Book2.PageNumber = 9;
        }

        [TestMethod]
        public void Isbn13Validation()
        {
            Book Book = new Book("title", "Author", 11, "aaaaaaaaaaaaa");

            Assert.AreEqual("aaaaaaaaaaaaa", Book.Isbn13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13Exception()
        {
            Book Book2 = new Book("t", "Author", 9, "123456789100098787");
            Book2.Isbn13 = "123456789100098787";
        }
    }
}
