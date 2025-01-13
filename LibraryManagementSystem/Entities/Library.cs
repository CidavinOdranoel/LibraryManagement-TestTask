using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Entities
{
    public class Library
    {
        private static Library instance = null;
        private static object instanceLock = new object();
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();

        private Library()
        {
        }

        public static Library? Instance 
        {
            get
            {
                if (instance == null)
                    lock (instanceLock)
                    {
                        if (Instance == null) instance = new Library();
                    }
                return instance;
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> FindBooksByTitle(string title)
        {
            return books.FindAll(x => x.Title == title);
        }

        public List<Book> FindBooksByAuthor(string author)
        {
            return books.FindAll(x => x.Author == author);
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }
    }
}