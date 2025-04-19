using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolioMvc.Models
{
    public class Skill
    {
        [Key] // Explicit primary key annotation (optional)
        public int SkillID { get; set; }  // Primary key

        [Required]
        [MaxLength(100)]
        public string SkillName { get; set; }  // Skill name (e.g., "React.js")

        [Required]
        public string ProficiencyLevel { get; set; }  // Proficiency level (e.g., "Expert", "Intermediate")

        // Foreign key linking to the User table
        [ForeignKey("User")]
        public int UserID { get; set; }

        public User User { get; set; }  // Navigation property
    }
}