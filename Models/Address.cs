using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBradster.Models
{
    public class Address
    {
       
        public int Id { get; set; }

        [Display(Name = "Address")]
        [StringLength(100, ErrorMessage = "Address length must be 100 characters or less.")]
        public string? AddressLine { get; set; }

        [StringLength(35, ErrorMessage = "City length must be 35 characters or less.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string? City { get; set; }

        [StringLength(50, ErrorMessage = "State length must be 50 characters or less.")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string? State { get; set; }

        [DataType(DataType.PostalCode)]
        [Range(10000, 99999, ErrorMessage = "Enter a valid Zip code.")]
        public string? Zip { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;

    }
}
