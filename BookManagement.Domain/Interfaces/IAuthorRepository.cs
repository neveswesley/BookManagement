using BookManagement.Domain.Entities;

namespace BookManagement.Domain.Interfaces;

public interface IAuthorRepository
{
    Author AddAuthor(Author author);
    Author? GetAuthorById(Guid id);
    List<Author> GetAuthors();
    void UpdateAuthor(Author author);
    void DeleteAuthor(Author author);
}