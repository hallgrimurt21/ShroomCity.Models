namespace ShroomCity.Models.Entities;

public class AttributeType
{
    public int Id { get; set; }
    public required string Type { get; set; }

    // Navigation properties
    public List<Attribute> Attributes { get; set; } = new List<Attribute>();
}

