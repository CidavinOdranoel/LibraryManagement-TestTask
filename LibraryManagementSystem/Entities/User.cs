using System.Collections.Generic;

namespace LibraryManagementSystem.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public User(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
    }
}