using ExamDistribution.Data;
using ExamDistribution.Services.Interfaces;
using ExamDistribution.ViewModels;
using Microsoft.EntityFrameworkCore;


public class DepartmentService : IDepartmentService
{
    private readonly AppDbContext _context;

    public DepartmentService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<DepartmentFacilityViewModel>> GetDepartmentsByFacilityAsync(string facilityId)
    {
        return await (from df in _context.DepartmentFacilities
                      join d in _context.Departments on df.DepartmentId equals d.Id
                      where df.FacilityId == facilityId
                      select new DepartmentFacilityViewModel
                      {
                          Id = df.Id,
                          DepartmentId = d.Id,
                          DepartmentName = d.Name
                      }).ToListAsync();
    }
}

