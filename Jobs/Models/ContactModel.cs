using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class ContactModel
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
