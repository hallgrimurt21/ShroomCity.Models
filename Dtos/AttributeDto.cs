namespace ShroomCity.Models.Dtos;

public class AttributeDto
{
    public int Id { get; set; }
    public required string Value { get; set; }
    public required string Type { get; set; }
    public required string RegisteredBy { get; set; }
    public DateTime? RegistrationDate { get; set; }
}
