namespace BookManagement.Domain.DTOs;

public class UpdatePriceDto
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
}