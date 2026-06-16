namespace BookManagement.Domain.DTOs;

public class GetBookDto
{
    public string Title { get; set; } = string.Empty;
    public GetAuthorDto? Author { get; set; }
    public int Year { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; }
}