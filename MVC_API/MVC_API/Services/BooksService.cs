namespace MVC_API
{
    public class BookService
    {
        public bool BookExists(int id)
        {
            var allBooks = GetAllBooks();
            return allBooks.Any(a => a.Id == id);
        }
        public List<Book> GetAllBooks()
        {
            return BooksModel.GetAllBooks();
        }

        public Book? GetBook(int id)
        {
            return BooksModel.GetBook(id);
        }

        public List<Book> GetBooksByAuthorId(int id)
        {
            return BooksModel.GetBooksByAuthorId(id);
        }

        public void PostBook(Book book)
        {
            var books = BooksModel.GetAllBooks();
            var highestID = books.Last().Id + 1;

            book.Id = highestID;
            BooksModel.PostBook(book);
        }

        public void DeleteBook(int id)
        {
            BooksModel.DeleteBook(id);
        }
    }
}
