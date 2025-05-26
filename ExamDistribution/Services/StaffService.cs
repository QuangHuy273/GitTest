using ExamDistribution.Data;
using ExamDistribution.Models;
using ExamDistribution.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamDistribution.Services.Implementations
{
    public class StaffService : IStaffService
    {
        private readonly AppDbContext _context;

        public StaffService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Staff>> GetAllAsync()
        {
            return await _context.Staffs.ToListAsync();
        }

        public async Task<Staff?> GetByIdAsync(string id)
        {
            return await _context.Staffs.FindAsync(id);
        }
    }
}

