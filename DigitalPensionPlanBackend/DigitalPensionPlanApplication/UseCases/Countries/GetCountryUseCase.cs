using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Countries
{
    public class GetCountryUseCase(ICountryRepository countryRepository)
    {
        public async Task<CountryDTO?> ExecuteAsync(Guid countryId)
        {
            var country = await countryRepository.GetByIdAsync(countryId);

            return country != null 
                ? new CountryDTO(country.CountryId, country.CountryName, country.CountryAbbreviation) 
                : null;
        }
    }
}
