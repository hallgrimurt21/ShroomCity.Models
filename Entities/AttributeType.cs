namespace ShroomCity.Models.Entities;

public class AttributeType
{
    public int Id { get; set; }
    public required string Type { get; set; }

    // Navigation properties
    public Attribute? Attribute { get; set; } // Navigation property
}

