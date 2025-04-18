using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Employee : Person
    {

        public int EmpId { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100)]
        public new string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public new string Email { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
