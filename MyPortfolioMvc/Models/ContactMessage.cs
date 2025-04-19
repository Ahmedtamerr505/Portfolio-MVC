using System;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioMvc.Models
{
    public class ContactMessage
    {
        [Key] // Explicit primary key annotation (optional)
        public int MessageID { get; set; }  // Primary key

        [Required]
        [MaxLength(100)] // Restrict maximum length
        public string Name { get; set; }  // Sender's name

        [Required]
        [EmailAddress] // Validate email format
        public string Email { get; set; }  // Sender's email

        [Required]
        [MaxLength(1000)] // Restrict maximum message length
        public string Message { get; set; }  // Message content

        public DateTime SentAt { get; set; } = DateTime.Now;  // Timestamp

    }
}