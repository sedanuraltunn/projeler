using System.ComponentModel.DataAnnotations;

namespace HtmlLesson.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string? Name { get; set; }

        [MaxLength(30)]
        public string? Lastname { get; set; }

        [MaxLength(16)]
        public string Username { get; set; } = string.Empty;

        [MaxLength(20)]
        public long Phone { get; set; } = long.MinValue;

        public DateTime? Birthday { get; set; }

        [MaxLength(75)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        [MaxLength(16)]
        public string Password { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
