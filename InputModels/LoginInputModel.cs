namespace ShroomCity.Models.InputModels;
using System.ComponentModel.DataAnnotations;

public class LoginInputModel
{
    [Required]
    [EmailAddress]
    public required string EmailAddress { get; set; }

    [Required]
    [MinLength(6)]
    public required string Password { get; set; }
}
