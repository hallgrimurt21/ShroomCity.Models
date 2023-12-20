namespace ShroomCity.Models.Entities;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Bio { get; set; }
    public required string HashedPassword { get; set; }
    public DateTime RegisterationDate { get; set; }
    public required string EmailAddress { get; set; }

    // Navigation properties
    public required Role Role { get; set; }

}
