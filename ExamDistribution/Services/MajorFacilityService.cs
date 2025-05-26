using ExamDistribution.Data;
using ExamDistribution.Models;
using ExamDistribution.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamDistribution.Services
{
    public class MajorFacilityService : IMajorFacilityService
    {
        private readonly AppDbContext _context;

        public MajorFacilityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<MajorFacility>> GetByDepartmentFacilityIdAsync(string departmentFacilityId)
        {
            return await _context.MajorFacilities
                .Include(mf => mf.Major)
                .Where(mf => mf.DepartmentFacilityId == departmentFacilityId)
                .ToListAsync();
        }
    }
}
