using ExamDistribution.Models;

namespace ExamDistribution.Services.Interfaces
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAllAsync();
        Task<Staff?> GetByIdAsync(string id);
    }
}

