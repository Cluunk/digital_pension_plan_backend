using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class HostRepository(ApplicationDbContext context) : IHostRepository
    {
        public async Task<Host> CreateHostAsync(Host host)
        {
            context.Hosts.Add(host);
            await context.SaveChangesAsync();
            return host;
        }

        public Task<List<Host>> GetAllAsync()
        {
            return context.Hosts
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Host?> GetByIdAsync(Guid hostId)
        {
            return context.Hosts
                .AsNoTracking()
                .FirstOrDefaultAsync(h => h.HostId == hostId);
        }

        public async Task<Host> UpdateHostAsync(Host host)
        {
            var existingHost = await context.Hosts.FirstOrDefaultAsync(h => h.HostId == host.HostId) ?? throw new KeyNotFoundException("Host not found");

            existingHost.Update(host.UserRoleId, host.HostName);

            await context.SaveChangesAsync();
            return existingHost;
        }

        public async Task DeleteHostAsync(Guid hostId)
        {
            var host = await context.Hosts.FirstOrDefaultAsync(h => h.HostId == hostId) ?? throw new KeyNotFoundException("Host not found");

            context.Hosts.Remove(host);
            await context.SaveChangesAsync();
        }
    }
}
