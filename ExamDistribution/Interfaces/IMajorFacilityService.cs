using ExamDistribution.Models;

namespace ExamDistribution.Services.Interfaces
{
    public interface IMajorFacilityService
    {
        Task<List<MajorFacility>> GetByDepartmentFacilityIdAsync(string departmentFacilityId);
    }
}

