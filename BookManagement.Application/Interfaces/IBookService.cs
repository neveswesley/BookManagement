using BookManagement.Domain.DTOs;
using BookManagement.Domain.Entities;

namespace BookManagemant.Interfaces;

public interface IBookService
{
    GetCreatedBookDto Create(CreateBookDto book);
    void SetAuthor(Guid authorId, Guid bookId);
    Book GetById(Guid bookId);
    List<GetBookDto> GetAll();
    void Update(Guid bookId, UpdateBookDto updateBookDto);
    void Delete(Guid bookId);
    void UpdateTitle(Guid bookId, string newTitle);
    void UpdatePrice(UpdatePriceDto updatePriceDto);
}