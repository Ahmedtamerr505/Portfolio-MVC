using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioMvc.Models
{
    public class User
    {
        [Key] // Explicit primary key annotation (optional, for clarity)
        public int UserID { get; set; }  // Primary key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }  // User's name

        [Required]
        [EmailAddress]
        public string Email { get; set; }  // User's email

        [MaxLength(500)]
        public string Bio { get; set; }  // User's biography

        public string ProfilePicture { get; set; }  // Profile picture URL or path

        // Navigation properties for related projects and skills
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}