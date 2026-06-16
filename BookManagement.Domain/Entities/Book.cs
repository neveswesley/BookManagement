namespace BookManagement.Domain.Entities;

public class Book
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; }
    public Guid? AuthorId { get; private set; }
    public Author? Author { get; private set; }
    public int Year { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public string Genre { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    public Book(string title, string description, int year, string genre, decimal price)
    {
        Title = title;
        Description = description;
        Year = year;
        Genre = genre;
        Price = price;
    }

    public void UpdateBook(string title, Guid authorId, string description, int year, string genre, decimal price)
    {
        Title = title;
        AuthorId = authorId;
        Description = description;
        Year = year;
        Genre = genre;
        Price = price;
    }

    public void SetAuthor(Guid authorId)
    {
        AuthorId = authorId;
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
    }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
    }
    
}