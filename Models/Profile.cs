using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IUBAlumniUSA.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        public string State { get; set; }

        public byte[] ProfilePicture { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }

}
