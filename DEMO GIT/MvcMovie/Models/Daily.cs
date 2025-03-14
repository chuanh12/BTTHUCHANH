using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class DaiLy
    {
        [Key]
        public required string MaDaiLy { get; set; }  // Khoá chính

        [Required]
        [StringLength(100)]
        public required string TenDaiLy { get; set; }  // Tên đại lý

        [StringLength(200)]
        public required string DiaChi { get; set; }  // Địa chỉ

        [StringLength(100)]
        public required string NguoiDaiDien { get; set; }  // Người đại diện

        [StringLength(15)]
        public required string DienThoai { get; set; }  // Số điện thoại

        [Required]
        public required string MaHTPP { get; set; }  // Mã hệ thống phân phối

        // Mối quan hệ với bảng HeThongPhanPhoi (1:N)
        public required HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}
