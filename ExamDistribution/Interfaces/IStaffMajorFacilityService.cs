using ExamDistribution.Models;
using ExamDistribution.ViewModels;

namespace ExamDistribution.Services.Interfaces
{
    public interface IStaffMajorFacilityService
    {
        Task<List<StaffMajorFacilityViewModel>> GetByStaffIdAsync(string staffId);
        Task<bool> CheckDuplicateAsync(string staffId, string facilityId);
        Task AddAsync(string staffId, string majorFacilityId);
        Task DeleteAsync(string id);
    }

}

