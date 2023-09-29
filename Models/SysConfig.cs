namespace IUBAlumniUSA.Models
{
    public class SysConfig
    {        
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string? Type { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateTS { get; set; }
    }
}
