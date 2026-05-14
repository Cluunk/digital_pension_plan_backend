using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanApplication.UseCases.Genders.GetGender;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Genders.GetGenders
{
    public class GetGendersUseCase(IGenderRepository genderRepository) : IGetGendersUseCase
    {
        public async Task<List<GenderDTO>> ExecuteAsync()
        {
            var genders = await genderRepository.GetAllAsync();
            return genders.Select(gender => new GenderDTO(gender.GenderId, gender.GenderDescription)).ToList();
        }
    }
}
