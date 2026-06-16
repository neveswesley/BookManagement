namespace BookManagement.Domain.Entities;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } =  string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public int Age { get; set; }
    public List<Book>? Books { get; set; }


    public Author(string name, string nationality, int age)
    {
        Name =  name;
        Nationality = nationality;
        Age = age;
    }
}