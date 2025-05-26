using ExamDistribution.Models;

namespace ExamDistribution.Services.Interfaces
{
    public interface IFacilityService
    {
        Task<List<Facility>> GetAllAsync();
        Task<Facility?> GetByIdAsync(string id);
    }
}

