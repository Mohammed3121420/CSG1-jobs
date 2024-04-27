using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class ContactModel
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Name not be exceed")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
