using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class DaiLy
    {
        [Key]
        [Required]
        public string MaDaiLy { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenDaiLy { get; set; } = string.Empty;

        [StringLength(200)]
        public string DiaChi { get; set; } = string.Empty;

        [StringLength(100)]
        public string NguoiDaiDien { get; set; } = string.Empty;

        [StringLength(15)]
        public string DienThoai { get; set; } = string.Empty;

        [Required]
        public string MaHTPP { get; set; } = string.Empty;
        // Mối quan hệ với bảng HeThongPhanPhoi (1:N)
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; } = new HeThongPhanPhoi();
    }
}
