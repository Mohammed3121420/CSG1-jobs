using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class signUpModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string fallName { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string type { get; set; }

    }
}
