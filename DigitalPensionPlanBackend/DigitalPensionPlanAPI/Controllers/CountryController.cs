using DigitalPensionPlanApplication.UseCases.Countries;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController(GetCountryUseCase getCountry, GetCountriesUseCase getCountries) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(await getCountries.ExecuteAsync());
        }

        [HttpGet("{countryId}")]
        public async Task<IActionResult> GetById(Guid countryId)
        {
            var country = await getCountry.ExecuteAsync(countryId);

            if (country == null)
                return NotFound();

            return Ok(country);
        }
    }
}
