﻿namespace MVC_API
{
    public class AuthorService
    {
        public bool authorExists(int id)
        {
            var allAuthors = GetAllAuthors();
            return allAuthors.Any(a => a.Id == id);
        }
        public List<Author> GetAllAuthors()
        {
            return AuthorModel.GetAllAuthors();
        }

        public Author? GetAuthor(int id)
        {
            return AuthorModel.GetAuthor(id);
        }

        public void PostAuthor(Author author)
        {
            var authors = AuthorModel.GetAllAuthors();
            var highestID = authors.Last().Id + 1;

            author.Id = highestID;
            AuthorModel.PostAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            AuthorModel.DeleteAuthor(id);
        }
    }
}
