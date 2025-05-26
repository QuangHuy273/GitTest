using Microsoft.EntityFrameworkCore;
using ExamDistribution.Models;

namespace ExamDistribution.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentFacility> DepartmentFacilities { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<MajorFacility> MajorFacilities { get; set; }
        public DbSet<StaffMajorFacility> StaffMajorFacilities { get; set; }
        public IEnumerable<object> StaffMajorFacility { get; internal set; }
        
    }
}

