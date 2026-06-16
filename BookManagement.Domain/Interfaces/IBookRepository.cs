using BookManagement.Domain.Entities;

namespace BookManagement.Domain.Interfaces;

public interface IBookRepository
{
    Book CreateBook(Book book);
    Book? GetById(Guid id);
    List<Book> GetBooks();
    void DeleteBook(Book book);
    void UpdateBook(Book book);
}