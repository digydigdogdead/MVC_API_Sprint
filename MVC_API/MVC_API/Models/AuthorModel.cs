using System.Text.Json;

namespace MVC_API
{
    public class AuthorModel
    {
        public static List<Author> GetAllAuthors()
        {
            return JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json"));
        }

        public static Author? GetAuthor(int id) 
        {
            var allAuthors = GetAllAuthors();
            foreach (var author in allAuthors)
            {
                if (author.Id == id)
                {
                    return author;
                }
            }
            return null;
        }
    }
}
