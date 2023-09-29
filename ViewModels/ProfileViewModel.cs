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
     
    [MaxLength(14)]
    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "You must provide a phone number")]
     
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

    public string PhoneNumber { get; set; }
    public string? EmailAddress { get; set; }

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
    public String? BatchTerm { get; set; }
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

    
    //[MaxLength(200)]
    public String? Degree { get; set; }


    public SelectList? DegreeList
    {
        get
        {
            SelectList? selectList = null;
            if (context != null)
            {
                selectList = new SelectList(context.Degrees, "Id", "DegreeName");
                foreach(var item in selectList)
                {
                    if (this.Degree?.Split(",").Contains(item.Value)==true)
                    {
                        item.Selected = true;
                    }
                }
            }
            return selectList;
        }
    }
    [Required(ErrorMessage = "Please select at least one degree")]
    public string[] DegreeSelected { set; get; }

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

    [Display(Name = "Approved")]
    public Boolean IsApproved { get; set; }
    [Display(Name = "Admin")]
    public Boolean IsAdmin { get; set; }

    public string? IdentityUserId { get; set; }
}
