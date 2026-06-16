namespace BookManagement.Domain.DTOs;

public class GetAuthorDto
{
    public string Name { get; set; } = string.Empty;
    public List<GetAuthorBooksDto>? Books { get; set; } = [];
}