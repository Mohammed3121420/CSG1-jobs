using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class signUpModel
    {
        [Key]
        public int id { get; set; }
<<<<<<< HEAD

=======
        
>>>>>>> 365c86b0a5f26166fad589c98a67f45785a7aae1
        [Required]
        public string fallName { get; set; }

        [Required]
        public string username { get; set; }
<<<<<<< HEAD

=======
        
>>>>>>> 365c86b0a5f26166fad589c98a67f45785a7aae1
        [Required]
        public string email { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string password { get; set; }
<<<<<<< HEAD

        [Required]
        public string type { get; set; }







=======
        
       
        
        
        
>>>>>>> 365c86b0a5f26166fad589c98a67f45785a7aae1
    }
}
