using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        [Key]
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;

        [EmailAddress]
        public string? Email { get; set; }
    }
}
