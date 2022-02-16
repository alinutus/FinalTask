using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class BooksChecker
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Empty FirstName")]
        public void CheckForNotEmptyFieldsValid()
        {
            BookAuthor author = new BookAuthor();
            author.AuthorFirstName = string.Empty;
        }

    }
}