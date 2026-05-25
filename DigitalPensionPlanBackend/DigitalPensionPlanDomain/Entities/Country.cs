using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Country
    {
        public required Guid CountryId { get; init; }
        public required string CountryName { get; init; }
        public required string CountryAbbreviation { get; init; }
    }
}
