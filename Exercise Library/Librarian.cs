using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Library
{
    class Librarian
    {
        private Library library { get; set; }

        public Librarian(Library lab)
        {
            library = lab;
        }

        /// <summary>
        /// Request a book by author.Checks if the user and book exist.
        /// </summary>
        /// <param name="author">aythor's name</param>
        /// <param name="userID">user's id</param>
        /// <returns></returns>
        public List<Book> RequestBookByAuthor(string author, string userID)
        {
            if (library.AuthenticateUser(userID) == false)
                throw new Exception("User is not allowed to access books");
            List<Book> books = library.SearchByAuthor(author);
            if (books.Count == 0)
                throw new Exception("No books found for requested author");
            foreach (Book b in books)
                library.RemoveBook(b);
            return books;
        }

        /// <summary>
        /// Request a book by title.Checks if the user and book exist.
        /// </summary>
        /// <param name="title">book's title</param>
        /// <param name="userID">user's id</param>
        /// <returns></returns>
        public Book RequestBookByTitle(string title, string userID)
        {
            if (library.AuthenticateUser(userID) == false)
                throw new Exception("User is not allowed to access books");

            Book book = library.SearchByBookTitle(title);
            if (book == null)
                throw new Exception("No books found for requested title");
            library.RemoveBook(book);
            return book;
        }
    }
}
