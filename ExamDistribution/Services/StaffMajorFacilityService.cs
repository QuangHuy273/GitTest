using ExamDistribution.Data;
using ExamDistribution.Models;
using ExamDistribution.Services.Interfaces;
using ExamDistribution.ViewModels;
using Microsoft.EntityFrameworkCore;

public class StaffMajorFacilityService : IStaffMajorFacilityService
{
    private readonly AppDbContext _context;

    public StaffMajorFacilityService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<StaffMajorFacilityViewModel>> GetByStaffIdAsync(string staffId)
    {
        return await (from smf in _context.StaffMajorFacilities
                      join mf in _context.MajorFacilities on smf.MajorFacilityId equals mf.Id
                      join m in _context.Majors on mf.MajorId equals m.Id
                      join df in _context.DepartmentFacilities on mf.DepartmentFacilityId equals df.Id
                      join d in _context.Departments on df.DepartmentId equals d.Id
                      join f in _context.Facilities on df.FacilityId equals f.Id
                      where smf.StaffId == staffId
                      select new StaffMajorFacilityViewModel
                      {
                          Id = smf.Id,
                          StaffId = smf.StaffId,
                          FacilityName = f.Name,
                          DepartmentName = d.Name,
                          MajorName = m.Name
                      }).ToListAsync();
    }

    public async Task<bool> CheckDuplicateAsync(string staffId, string facilityId)
    {
        return await (from smf in _context.StaffMajorFacilities
                      join mf in _context.MajorFacilities on smf.MajorFacilityId equals mf.Id
                      join df in _context.DepartmentFacilities on mf.DepartmentFacilityId equals df.Id
                      where smf.StaffId == staffId && df.FacilityId == facilityId
                      select smf).AnyAsync();
    }

    public async Task AddAsync(string staffId, string majorFacilityId)
    {
        var entity = new StaffMajorFacility
        {
            Id = Guid.NewGuid().ToString(),
            StaffId = staffId,
            MajorFacilityId = majorFacilityId,
            CreatedDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
            LastModifiedDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        };

        _context.StaffMajorFacilities.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
    {
        var entity = await _context.StaffMajorFacilities.FindAsync(id);
        if (entity != null)
        {
            _context.StaffMajorFacilities.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
