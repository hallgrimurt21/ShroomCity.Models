namespace ShroomCity.Models.Entities;

#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class Permission
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
    public int Id { get; set; }
    public required string Code { get; set; }
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<Role> Roles { get; set; } = new List<Role>();
}
