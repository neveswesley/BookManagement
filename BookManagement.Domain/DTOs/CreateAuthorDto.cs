namespace BookManagement.Domain.DTOs;

public class CreateAuthorDto
{
    public string Name { get; set; } =  string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public int Age { get; set; }
}