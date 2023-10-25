using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TheBradster.Models
{
    public class Accounts
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [Column("First Name")]
        [StringLength(50, ErrorMessage ="First name length must be 50 characters or less.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [Column("Last Name")]
        [StringLength(50, ErrorMessage = "Last name length must be 50 characters or less.")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [StringLength(100, ErrorMessage = "Address length must be 100 characters or less.")]
        public string? Address { get; set; }

        [StringLength(35, ErrorMessage = "City length must be 35 characters or less.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string? City { get; set; }

        [StringLength(50, ErrorMessage = "State length must be 50 characters or less.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string? State { get; set; }

        [DataType(DataType.PostalCode)]
        [Range(10000, 99999, ErrorMessage = "Enter a valid Zip code.")]
        public string? Zip { get; set; }

        [ValidateNever]
        public User User { get; set; } = null!;

        [Required(ErrorMessage = "Please enter in your user information")]
        public int UserId { get; set; } 
        
        


    }
}
