using BookManagement.Domain.DTOs;
using BookManagement.Domain.Entities;

namespace BookManagemant.Interfaces;

public interface IAuthorService
{
    GetAuthorDto CreateAuthor(CreateAuthorDto author);
    GetAuthorDto? GetAuthorById(Guid id);
    List<GetAuthorDto> GetAuthors();
    void UpdateAuthor(Author author);
    void DeleteAuthor(Author author);
}