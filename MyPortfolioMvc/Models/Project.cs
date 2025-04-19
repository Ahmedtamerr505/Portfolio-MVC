using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolioMvc.Models
{
    public class Project
    {
        [Key] // Explicit primary key annotation (optional)
        public int ProjectID { get; set; }  // Primary key

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }  // Project title

        [MaxLength(500)]
        public string Description { get; set; }  // Project description

        [MaxLength(300)]
        public string TechnologiesUsed { get; set; }  // Technologies used in the project

        [Url]
        public string ProjectURL { get; set; }  // URL to the project/repository

        [Url]
        public string ImageURL { get; set; }  // Project image URL or path

        // Foreign key linking to the User table
        [ForeignKey("User")]
        public int UserID { get; set; }

        public User User { get; set; }  // Navigation property
    }
}