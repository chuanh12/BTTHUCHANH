using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        [Required]
        public string MaHTPP { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenHTPP { get; set; } = string.Empty;
    }
}
