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

        public static void PostAuthor(Author author)
        {
            var allAuthors = GetAllAuthors();
            allAuthors.Add(author);

            File.WriteAllText("Resources/Authors.json", JsonSerializer.Serialize(allAuthors));
        }

        public static void DeleteAuthor(int id)
        {
            var allAuthors = GetAllAuthors();
            var authorToDelete = allAuthors.Where(x => x.Id == id).ToList()[0];
            allAuthors.Remove(authorToDelete);

            File.WriteAllText("Resources/Authors.json", JsonSerializer.Serialize(allAuthors));
        }
    }
}
