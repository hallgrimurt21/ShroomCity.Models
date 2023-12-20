namespace ShroomCity.Models.InputModels;
using System.ComponentModel.DataAnnotations;


public class MushroomUpdateInputModel
{
    [Required]
    public required string Name { get; set; }
    public string? Description { get; set; }
}
