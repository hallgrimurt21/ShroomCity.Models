namespace ShroomCity.Models.Dtos;

public class UserDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string EmailAddress { get; set; }
    public string? Bio { get; set; }
    public required List<string> Permissions { get; set; }
    public int TokenId { get; set; }
}
