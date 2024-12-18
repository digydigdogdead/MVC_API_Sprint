using System.Text.Json;

namespace MVC_API
{
    public class BooksModel
    {
        public static List<Book> GetAllBooks()
        {
            return JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("Resources/Books.json"));
        }

        public static Book? GetBook(int id)
        {
            var allBooks = GetAllBooks();
            foreach (var book in allBooks)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }

        public static void PostBook(Book book)
        {
            var allBooks = GetAllBooks();
            allBooks.Add(book);

            File.WriteAllText("Resources/Books.json", JsonSerializer.Serialize(allBooks));
        }

        public static void DeleteBook(int id)
        {
            var allBooks = GetAllBooks();
            var bookToDelete = allBooks.Where(x => x.Id == id).ToList()[0];
            allBooks.Remove(bookToDelete);

            File.WriteAllText("Resources/Books.json", JsonSerializer.Serialize(allBooks));
        }
    }
}
