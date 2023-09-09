using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUBAlumniUSA.Models;

public class Degree
{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string DegreeName { get; set; }

    [MaxLength(1)]
    public string DegreeLevel { get; set; }
}
