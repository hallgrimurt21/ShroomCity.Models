namespace ShroomCity.Models.Dtos;
using System.Text.Json.Serialization;

public class ExternalAttributeDto
{
    [JsonPropertyName("_id")]
    public required string Id { get; set; }
    public required string Name { get; set; }
}
