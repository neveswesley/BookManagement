namespace BookManagement.Domain.DTOs;

public class CreateBookDto
{
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; }
}