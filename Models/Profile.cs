using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using AutoMapperProfile = AutoMapper.Profile;

using IUBAlumniUSA.ViewModels;

namespace IUBAlumniUSA.Models;

public class Profile //: AutoMapperProfile
{
    public Profile()
    {
        //CreateMap<Profile, ProfileViewModel>();
    }
    
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Batch Year")]
    public int BatchYear { get; set; }

    [Display(Name = "Batch Term")]
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
    [Display(Name = "Province Or State")]
    public String? ProvinceState { get; set; }
    [MaxLength(7)]
    [Display(Name = "Zip Or Postal Code")]
    public String? ZipPostalCode { get; set; }

    [Display(Name = "Profile Picture")]
    public byte[]? ProfilePicture { get; set; }
    

    public Boolean IsApproved { get; set; }

    [ForeignKey("IdentityUser")]
    public string IdentityUserId { get; set; }
}
