namespace LibraryManagementSystem.Entities
{
    public partial class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public string Publisher { get; private set; }
        public int YearPublished { get; private set; }
        public string Genre { get; private set; }
        public bool IsBorrowed { get; private set; }

        private Book(BookBuilder builder)
        {
        }

        public void Borrow()
        {
        }

        public void ReturnBook()
        {
        }
    }
}