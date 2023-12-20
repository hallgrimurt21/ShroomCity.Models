using System.Text.Json.Serialization;

namespace ShroomCity.Models.Dtos;

public class ExternalAttributeDto
{
    [JsonPropertyName("_id")]
    public required string Id { get; set; }
    public required string Name { get; set; }
}
