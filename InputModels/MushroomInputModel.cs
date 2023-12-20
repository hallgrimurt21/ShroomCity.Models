namespace ShroomCity.Models.InputModels;
using System.ComponentModel.DataAnnotations;

public class MushroomInputModel
{
    [Required]
    public required string Name { get; set; }
    public string? Description { get; set; }
}
