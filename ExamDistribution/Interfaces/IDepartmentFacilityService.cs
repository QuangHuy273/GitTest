using ExamDistribution.Models;

namespace ExamDistribution.Services.Interfaces
{
    public interface IDepartmentFacilityService
    {
        Task<List<DepartmentFacility>> GetByFacilityIdAsync(string facilityId);
    }
}
