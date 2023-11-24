using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class Register
    {
        [Key]
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
    