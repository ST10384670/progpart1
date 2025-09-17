using System;
using System.ComponentModel.DataAnnotations;

namespace st10384670proggggg.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        [Required]
        [StringLength(150)]
        public string? ClaimTitle { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime DateFiled { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string? Status { get; set; } // e.g., Pending, Approved, Rejected

        // Foreign Key → Docs (if claim relates to a document)
        public int DocsId { get; set; }
        public Docs? Docs { get; set; }
    }
}
