using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace st10384670proggggg.Models
{
    public class Lecturer
    {
        [Key]
        public int LecturerId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Phone { get; set; }

        public string? Address { get; set; }

        // Navigation property → Docs created/handled by this lecturer
        public ICollection<Docs>? Docs { get; set; }
    }
}
