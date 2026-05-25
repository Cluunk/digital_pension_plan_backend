using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Genders
{
    public class GetGendersUseCase(IGenderRepository genderRepository)
    {
        public async Task<List<GenderDTO>> ExecuteAsync()
        {
            var genders = await genderRepository.GetAllAsync();
            return genders.Select(gender => new GenderDTO(gender.GenderId, gender.GenderDescription)).ToList();
        }
    }
}
