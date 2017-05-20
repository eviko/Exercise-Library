using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Library
{
    class Library
    {
        List<Book> listOfBooks = new List<Book>();
        List<User> Users = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }

        /// <summary>
        /// Authenticates the user's id
        /// </summary>
        /// <param name="userID">user's id </param>
        /// <returns></returns>
        public bool AuthenticateUser(string userID)
        {
            foreach (User u in Users)
            {
                if (u.userID == userID)

                    return true;
            }
            return false;
        }

        /// <summary>
        /// Search for a book by the author's name in the listOfBooks list.
        /// </summary>
        /// <param name="author">author's name</param>
        /// <returns></returns>
        public List<Book> SearchByAuthor(string author)
        {
            List<Book> authorBooks = new List<Book>();
            foreach (Book b in listOfBooks)
            {
                if (b.author == author)
                {
                    authorBooks.Add(b);
                }
            }
            return authorBooks;
        }
        /// <summary>
        /// Search for a book by title in the listOfBooks list.
        /// </summary>
        /// <param name="title">The book title</param>
        /// <returns></returns>

        public Book SearchByBookTitle(string title)
        {

            foreach (Book b in listOfBooks)
            {
                if (b.title == title)
                {
                    return b;
                }
            }
            return null;
        }

        /// <summary>
        /// Add a book into the listOfBooks
        /// </summary>
        /// <param name="book">Object book</param>
        public void AddBook(Book book)
        {
            listOfBooks.Add(book);
            book.id = listOfBooks.Count.ToString();
        }

        /// <summary>
        /// Remove a book from the listOfBooks.
        /// </summary>
        /// <param name="book"></param>

        public void RemoveBook(Book book)
        {
            listOfBooks.Remove(book);
        }
        /// <summary>
        /// Get a book from the listOfBooks.
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public string GetBookFromTheList(string author)
        {
            foreach (Book b in listOfBooks)
                if (b.author == author)
                    return ($"Title: {b.title} author: {b.author} id{b.id}is available {Environment.NewLine}");
            return ($"The book with author name: {author} does not exist");
        }
    }
}
