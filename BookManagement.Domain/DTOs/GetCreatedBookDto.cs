namespace BookManagement.Domain.DTOs;

public class GetCreatedBookDto
{
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
}