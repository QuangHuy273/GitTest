using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDistribution.Models
{
    [Table("staff")]
    public class Staff
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Mã nhân viên không được để trống")]
        [MaxLength(15, ErrorMessage = "Mã nhân viên tối đa 15 ký tự")]
        [Column("staff_code")]
        public string StaffCode { get; set; }

        [Required(ErrorMessage = "Email FE không được để trống")]
        [MaxLength(100, ErrorMessage = "Email FE tối đa 100 ký tự")]
        [Column("account_fe")]
        public string AccountFe { get; set; }

        [Required(ErrorMessage = "Email FPT không được để trống")]
        [MaxLength(100, ErrorMessage = "Email FPT tối đa 100 ký tự")]
        [Column("account_fpt")]
        public string AccountFpt { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        [MaxLength(100, ErrorMessage = "Tên nhân viên tối đa 100 ký tự")]
        [Column("name")]
        public string Name { get; set; }

        [Column("status")]
        public byte? Status { get; set; }

        [Column("created_date")]
        public long? CreatedDate { get; set; }

        [Column("last_modified_date")]
        public long? LastModifiedDate { get; set; }
    }
}
