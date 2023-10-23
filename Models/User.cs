using System.ComponentModel.DataAnnotations;

namespace TheBradster.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
