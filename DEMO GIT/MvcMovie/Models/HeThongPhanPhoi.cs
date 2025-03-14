using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public required string MaHTPP { get; set; }  // Khoá chính

        [Required]
        [StringLength(100)]
        public required string TenHTPP { get; set; }  // Tên hệ thống phân phối
    }
}

