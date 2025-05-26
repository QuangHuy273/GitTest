using ExamDistribution.Data;
using ExamDistribution.Models;
using ExamDistribution.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamDistribution.Services
{
    public class DepartmentFacilityService : IDepartmentFacilityService
    {
        private readonly AppDbContext _context;

        public DepartmentFacilityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DepartmentFacility>> GetByFacilityIdAsync(string facilityId)
        {
            return await _context.DepartmentFacilities
                .Include(df => df.Department)
                .Where(df => df.FacilityId == facilityId)
                .ToListAsync();
        }
    }
}
