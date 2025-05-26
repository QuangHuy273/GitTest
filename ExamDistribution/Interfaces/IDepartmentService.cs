using ExamDistribution.ViewModels;

namespace ExamDistribution.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentFacilityViewModel>> GetDepartmentsByFacilityAsync(string facilityId);
    }
}


