using System.ComponentModel.DataAnnotations;

namespace TheBradster.Models
{
    public class Music
    {
        public int MusicId { get; set; }

        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Artist { get; set; }
        public DateTime? UploadedDate { get; set; } 
        public string? FilePath { get; set; }

        //Foriegn Id of Account model
        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;

        public string? Album { get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
        public byte[]? CoverImage { get; set; }


    }
}
