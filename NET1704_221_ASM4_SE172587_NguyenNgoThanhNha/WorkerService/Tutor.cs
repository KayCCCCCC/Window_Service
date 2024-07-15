using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorkerService
{
    public class Tutor
    {
        [Key] public int Id { get; set; }

        public Guid TutorId { get; set; }

        [Required]
        [DisplayName("Tên giảng viên")]
        [MaxLength(100, ErrorMessage = "Tên giảng viên tối đa 100 kí tự.")]
        public string Fullname { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(100, ErrorMessage = "Email tối đa 100 kí tự.")]
        public string Email { get; set; } = null!;

        [Required]
        [RegularExpression(@"^(\+84|0)[1-9]\d{8}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [DisplayName("Số điện thoại")]
        [MaxLength(12, ErrorMessage = "Số điện thoại tối đa 100 kí tự.")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
        [DisplayName("Địa chỉ")]
        [MaxLength(300, ErrorMessage = "Địa chỉ tối đa 300 kí tự.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
