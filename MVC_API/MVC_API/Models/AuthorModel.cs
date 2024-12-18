using System.Text.Json;

namespace MVC_API
{
    public class AuthorModel
    {
        public static List<Author> GetAllAuthors()
        {
            return JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json"));
        }
    }
}
