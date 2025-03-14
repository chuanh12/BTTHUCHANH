using MvcMovie.Models;

namespace MvcMovie.Models
{
    public class Employee : Persion
    {
        public required string EmployeeId { get; set; }  // Mã nhân viên
        public int Age { get; set; }            // Tuổi
    }
}