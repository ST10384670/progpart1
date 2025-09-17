using System;
using System.ComponentModel.DataAnnotations;

namespace st10384670proggggg.Models
{
    public class Docs
    {
        [Key]
        public int DocsId { get; set; }

        [Required]
        [StringLength(150)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Range(0, double.MaxValue)]
        public double FileSize { get; set; } // in KB/MB

        // Foreign Key → Lecturer
        public int LecturerId { get; set; }
        public Lecturer? Lecturer { get; set; }

        // If you want claims directly linked to docs
        public ICollection<Claim>? Claims { get; set; }
    }
}
