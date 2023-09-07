using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUBAlumniUSA.Models;

public class Profile
{          
    
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    public int BatchYear { get; set; }
    public int? BatchTerm { get; set; }
    
  //  [Required]
    [MaxLength(200)]
    public String? Degree { get; set; }

    [MaxLength(20)]
    public String? Country { get; set; }

    [MaxLength(100)]
    public String? Address { get; set; }

    [MaxLength(100)]
    public String? City { get; set; }

    [MaxLength(2)]
    public String? ProvinceState { get; set; }
    [MaxLength(7)]
    public String? ZipPostalCode { get; set; }

    public byte[]? ProfilePicture { get; set; }
    

    public Boolean IsApproved { get; set; }

    [ForeignKey("IdentityUser")]
    public string IdentityUserId { get; set; }
}
