namespace ShroomCity.Models.Dtos;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ExternalMushroomDto
{
    [JsonPropertyName("_id")]
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required List<string> Colors { get; set; }
    public required List<string> Shapes { get; set; }
    public required List<string> Surfaces { get; set; }
}
