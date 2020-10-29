using System.ComponentModel.DataAnnotations;

namespace GetAGame.Data
{
    public class User
    {
        [Key]
        public System.Guid Id { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}