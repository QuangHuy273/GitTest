using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDistribution.Models
{
    [Table("department")]
    public class Department
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("code")]
        public string? Code { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("status")]
        public byte? Status { get; set; }

        [Column("created_date")]
        public long? CreatedDate { get; set; }

        [Column("last_modified_date")]
        public long? LastModifiedDate { get; set; }
    }
}

