using ExamDistribution.Data;
using ExamDistribution.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

public class MajorService : IMajorService
{
    private readonly AppDbContext _context;

    public MajorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<MajorFacilityViewModel>> GetMajorsByDepartmentFacilityAsync(string departmentFacilityId)
    {
        return await (from mf in _context.MajorFacilities
                      join m in _context.Majors on mf.MajorId equals m.Id
                      where mf.DepartmentFacilityId == departmentFacilityId
                      select new MajorFacilityViewModel
                      {
                          Id = mf.Id,
                          MajorId = m.Id,
                          MajorName = m.Name
                      }).ToListAsync();
    }
}
