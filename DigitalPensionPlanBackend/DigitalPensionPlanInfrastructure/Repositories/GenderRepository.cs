using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class GenderRepository(ApplicationDbContext context) : IGenderRepository
    {
        public Task<List<Gender>> GetAllAsync()
        {
            return context.Genders.ToListAsync();
        }

        public Task<Gender?> GetByIdAsync(Guid genderId)
        {
            return context.Genders.FindAsync(genderId).AsTask();
        }
    }
}
