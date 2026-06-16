namespace BookManagement.Domain.DTOs;

public class UpdateBookDto
{
    public string Title { get; set; } = string.Empty;
    public Guid AuthorId { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; }
}