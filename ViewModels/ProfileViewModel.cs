using AutoMapper;
using IUBAlumniUSA.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using AutoMapperProfile = AutoMapper.Profile;
using Profile = IUBAlumniUSA.Models.Profile;

namespace IUBAlumniUSA.ViewModels;

public class ProfileViewModel : AutoMapperProfile
{
    private ApplicationDbContext context;
    public ProfileViewModel()
    {
        //context = _context;
        //source mapping to destination
        CreateMap<ProfileViewModel, Profile>();
        CreateMap<Profile, ProfileViewModel>();
    }
    public void SetContext(ApplicationDbContext _context)
    {
        context = _context;
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
    [Display(Name = "Batch Term")]
    public int? BatchTerm { get; set; }
    [Display(Name = "Batch Term Select")]
    public List<SelectListItem>? BatchTermSelectList
    {
        get
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem("01 - Autumn","01"),
                new SelectListItem("02 - Spring","02"),
                new SelectListItem("03 - Summer","03")
            };

            return list;
        }
    }

    //  [Required]
    [MaxLength(200)]
    public String? Degree { get; set; }


    public List<SelectListItem>? DegreeSelectList
    {
        get
        {
            var list = new List<SelectListItem>();
            if (context != null)
            {
                foreach (var degree in context.Degrees)
                {
                    var item = new SelectListItem(degree.DegreeName, degree.DegreeName);
                    list.Add(item);
                }
            }


            return list;
        }
    }

    [MaxLength(20)]
    public String? Country { get; set; }

    public List<string>? CountryList
    {
        get
        {
            var list = new List<string>
            {
                "USA", "Canada"
            };
            


            return list;
        }
    }


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
