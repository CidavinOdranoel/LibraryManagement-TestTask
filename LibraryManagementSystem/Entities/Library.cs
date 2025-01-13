using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Entities
{
    public class Library
    {
        private static Library instance = null;
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();

        private Library()
        {
        }

        public static Library Instance { }

        public void AddBook(Book book)
        {
        }

        public void RemoveBook(Book book)
        {
        }

        public List<Book> FindBooksByTitle(string title)
        {
        }

        public List<Book> FindBooksByAuthor(string author)
        {
        }

        public void RegisterUser(User user)
        {
        }
    }
}