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
        
        public bool AuthenticateUser(string userID)
        {
            foreach (User u in Users)
            {
                if (u.userID == userID)

                    return true;
            }
            return false;
        }

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
                
        public void AddBook(Book book)
        {
            listOfBooks.Add(book);
            book.id = listOfBooks.Count.ToString();
        }

        public void RemoveBook(Book book)
        {
            listOfBooks.Remove(book);
        }
        public string GetBookFromTheList(string author)
        {
            foreach (Book b in listOfBooks)
                if (b.author == author)
                    return ($"Title: {b.title} author: {b.author} id{b.id}is available {Environment.NewLine}");
            return ($"The book with author name: {author} does not exist");
        }


    }



}
