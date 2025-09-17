using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace st10384670proggggg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Username { get; set; }

        [Required]
        [StringLength(100)]
        public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        public string? Role { get; set; } // e.g., Admin, Lecturer, Student

        [EmailAddress]
        public string? Email { get; set; }

        // Navigation property → if users are linked to Docs they created
        public ICollection<Docs>? Docs { get; set; }
    }
}
