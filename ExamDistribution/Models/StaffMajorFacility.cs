using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDistribution.Models
{
    [Table("staff_major_facility")]
    public class StaffMajorFacility
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("id_major_facility")]
        public string? IdMajorFacility { get; set; }

        [Column("id_staff")]
        public string? IdStaff { get; set; }

        [Column("status")]
        public byte? Status { get; set; }

        [Column("created_date")]
        public long? CreatedDate { get; set; }

        [Column("last_modified_date")]
        public long? LastModifiedDate { get; set; }

        // Navigation properties
        public MajorFacility? MajorFacility { get; set; }
        public Staff? Staff { get; set; }
        public string StaffId { get; internal set; }
        public string MajorFacilityId { get; internal set; }
    }

}
