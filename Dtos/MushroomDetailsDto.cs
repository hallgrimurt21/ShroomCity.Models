namespace ShroomCity.Models.Dtos;

public class MushroomDetailsDto
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<AttributeDto> Attributes { get; set; } = new List<AttributeDto>();
}
