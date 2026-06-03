using DigitalPensionPlanDomain.Entities;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IHostRepository
    {
        Task<Host> CreateHostAsync(Host host);
        Task<List<Host>> GetAllAsync();
        Task<Host?> GetByIdAsync(Guid hostId);
        Task<Host> UpdateHostAsync(Host host);
        Task DeleteHostAsync(Guid hostId);
    }
}
