namespace ShroomCity.Models.Entities;

public class Mushroom
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<Attribute> Attributes { get; set; } = new List<Attribute>();
}
