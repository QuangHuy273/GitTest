using ExamDistribution.ViewModels;
using System.Threading.Tasks;

namespace ExamDistribution.Services.Interfaces
{
    public interface IMajorService
    {
        Task<List<MajorFacilityViewModel>> GetMajorsByDepartmentFacilityAsync(string departmentFacilityId);
    }

}


