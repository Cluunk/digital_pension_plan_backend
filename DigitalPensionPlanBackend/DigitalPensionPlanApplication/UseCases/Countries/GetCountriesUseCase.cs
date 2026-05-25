using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Countries
{
    public class GetCountriesUseCase(ICountryRepository countryRepository)
    {
        public async Task<List<CountryDTO>> ExecuteAsync()
        {
            var countries = await countryRepository.GetAllAsync();
            return countries.Select(country => new CountryDTO(country.CountryId, country.CountryName, country.CountryAbbreviation)).ToList();
        }
    }
}
