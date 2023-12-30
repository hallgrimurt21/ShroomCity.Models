namespace ShroomCity.Models.Entities;
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class Attribute
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
    public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string Value { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public int AttributeTypeId { get; set; }
    public int RegisteredById { get; set; }

    // Navigation properties
    public required AttributeType AttributeType { get; set; }
    public required User RegisteredBy { get; set; }
    public ICollection<Mushroom> Mushrooms { get; set; } = new List<Mushroom>();
}
