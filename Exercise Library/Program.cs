using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("C#", "Bobby Bob");
            Book b2 = new Book("SQL", "George Bob");
            Book b3 = new Book("Java", "John Bob");

            Library l1 = new Library();
            l1.AddBook(b1);
            l1.AddBook(b2);
            l1.AddBook(b3);                      

            User u1 = new User("Evi", "5050");
            User u2 = new User("Billy", "2020");
            User u3 = new User("Noula", "3030");
            User u4 = new User("John", "1010");

            l1.AddUser(u1);
            l1.AddUser(u2);
            l1.AddUser(u3);
            l1.AddUser(u4);

            Librarian Librarian1 = new Librarian(l1);

            try
            {
                List<Book> books = Librarian1.RequestBookByAuthor("Bobby Bob", "5051");
                Console.WriteLine("I got my books !");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("I did not got my books !");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();

        }

    }
}
