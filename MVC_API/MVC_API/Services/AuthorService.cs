using System.Text.Json;

namespace MVC_API
{
    public class AuthorService
    {
        public List<Author> GetAllAuthors()
        {
            return AuthorModel.GetAllAuthors();
        }

        public Author? GetAuthor(int id)
        {
            return AuthorModel.GetAuthor(id);
        }
    }
}
