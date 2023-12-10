using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TheBradster.Models
{
    public class Account
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

        //Navigation property to Address (one to one)
        public ICollection<Address> Address { get; set; } 

        //Navigation property to Music (one to many)
        public ICollection<Music> Music { get; set; } 

    }
}
