using System.Text.Json;

namespace MVC_API
{
    public class AuthorService
    {
        public List<Author> GetAllAuthors()
        {
            return AuthorModel.GetAllAuthors();
        }
    }
}
