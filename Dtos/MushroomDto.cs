namespace ShroomCity.Models.Dtos;
using System.Text.Json.Serialization;

public class MushroomDto
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
