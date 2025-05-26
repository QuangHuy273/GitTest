using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDistribution.Models
{
    [Table("major_facility")]
    public class MajorFacility
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("id_major")]
        public string? IdMajor { get; set; }

        [Column("id_department_facility")]
        public string? IdDepartmentFacility { get; set; }

        [Column("status")]
        public byte? Status { get; set; }

        [Column("created_date")]
        public long? CreatedDate { get; set; }

        [Column("last_modified_date")]
        public long? LastModifiedDate { get; set; }

        public Major? Major { get; set; }
        public DepartmentFacility? DepartmentFacility { get; set; }
        public string DepartmentFacilityId { get; internal set; }
        public string Facility { get; internal set; }
        public string MajorId { get; internal set; }
    }

}

