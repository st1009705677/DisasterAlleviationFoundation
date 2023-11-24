using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class User
    {
        [Key]
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
   