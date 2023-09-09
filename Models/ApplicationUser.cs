using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IUBAlumniUSA.Models;

public class ApplicationUser: IdentityUser
{
    [Required]
    public bool IsApproved { get; set; } = false;
}
