namespace ShroomCity.Models.Dtos;

public class ResearcherDto
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string EmailAddress { get; set; }
    public string? Bio { get; set; }
    public List<MushroomDto>? AssociatedMushrooms { get; set; }
}
