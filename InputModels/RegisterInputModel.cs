namespace ShroomCity.Models.InputModels;
using System.ComponentModel.DataAnnotations;

public class RegisterInputModel
{
    [Required]
    [MinLength(5)]
    public required string FullName { get; set; }

    [Required]
    [EmailAddress]
    public required string EmailAddress { get; set; }

    public string? Bio { get; set; }

    [Required]
    [MinLength(6)]
    public required string Password { get; set; }

    [Required]
    [Compare("Password")]
    public required string PasswordConfirmation { get; set; }
}
