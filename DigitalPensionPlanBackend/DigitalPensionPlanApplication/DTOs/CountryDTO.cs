using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.DTOs
{
    public record CountryDTO(Guid CountryId, string CountryName, string CountryAbbreviation);
}
