using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class CreateJob
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name not be exceed")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string JobName { get; set; }
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]

        [Required]
        [StringLength(100, ErrorMessage = "Description not be exceed")]
        public string JobDescription { get; set; }
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [Required]
        [StringLength(50,ErrorMessage = "Address not be exceed")]
        public string Address { get; set; }
        [Required]
        [StringLength(100)]
        public string Requirements { get; set; }
    }
}
