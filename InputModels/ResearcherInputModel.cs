namespace ShroomCity.Models.InputModels;
using System.ComponentModel.DataAnnotations;

public class ResearcherInputModel
{
    [Required]
    [EmailAddress]
    public required string EmailAddress { get; set; }
}
