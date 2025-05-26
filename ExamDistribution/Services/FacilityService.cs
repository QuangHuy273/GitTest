using ExamDistribution.Data;
using ExamDistribution.Models;
using ExamDistribution.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamDistribution.Services.Implementations
{
    public class FacilityService : IFacilityService
    {
        private readonly AppDbContext _context;

        public FacilityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Facility>> GetAllAsync()
        {
            return await _context.Facilities.ToListAsync();
        }

        public async Task<Facility?> GetByIdAsync(string id)
        {
            return await _context.Facilities.FindAsync(id);
        }
    }
}

