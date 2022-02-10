using System.ComponentModel.DataAnnotations;

namespace Lab3_ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Please enter a first name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter an E-mail")]
        public string? Email { get; set; }

        public string? Organization { get; set; }

        public DateTime DateAdded { get; set; }

        [Range (1,10, ErrorMessage ="Please select a category")]
        public int CategoryId { get; set; }
        
        public Category? Category { get; set; }

        public String Slug => FirstName?.Replace(' ', '-').ToLower()
            + '-' + LastName?.Replace(' ', '-').ToLower();

    }
}
