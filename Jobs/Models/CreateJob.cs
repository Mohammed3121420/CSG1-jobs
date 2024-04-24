using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class CreateJob
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string JobName { get; set; }
        [Required]
        [StringLength(100)]
        public string JobDescription { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(100)]
        public string Requirements { get; set; }
    }
}
