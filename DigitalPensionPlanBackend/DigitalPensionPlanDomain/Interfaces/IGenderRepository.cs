using DigitalPensionPlanDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IGenderRepository
    {
        Task<List<Gender>> GetAllAsync();
        Task<Gender?> GetByIdAsync(Guid genderId);
    }
}
