using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using AutoMapperProfile = AutoMapper.Profile;
using Profile = IUBAlumniUSA.Models.Profile;

namespace IUBAlumniUSA.ViewModels;

public class ProfileViewModel : AutoMapperProfile
{
    public ProfileViewModel()
    {
        //source mapping to destination
        CreateMap<ProfileViewModel, Profile>();
        CreateMap<Profile, ProfileViewModel>();
    }

    public int? Id { get; set; }

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

    // [Required]
    [Display(Name = "Batch Year Select")]
    public List<SelectListItem>? BatchYearsSelectList
    {
        get
        {
            var list = new List<SelectListItem>();

            for (var year = 1993; year < DateTime.Now.Year - 3; year++)
            {
                var item = new SelectListItem(year.ToString(), year.ToString());
                list.Add(item);
            }
            return list;
        }
    }

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


    //public string IdentityUserId { get; set; }
}
