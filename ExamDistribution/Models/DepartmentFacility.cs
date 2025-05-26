using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDistribution.Models
{
    [Table("department_facility")]
    public class DepartmentFacility
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("id_department")]
        public string? IdDepartment { get; set; }

        [Column("id_facility")]
        public string? IdFacility { get; set; }

        [Column("id_staff")]
        public string? IdStaff { get; set; }

        [Column("status")]
        public byte? Status { get; set; }

        [Column("created_date")]
        public long? CreatedDate { get; set; }

        [Column("last_modified_date")]
        public long? LastModifiedDate { get; set; }

        public Department? Department { get; set; }
        public Facility? Facility { get; set; }
        public Staff? Staff { get; set; }
        public string FacilityId { get; internal set; }
        public string DepartmentId { get; internal set; }
    }

}

