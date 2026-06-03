using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Country
    {
        public Guid CountryId { get; private set; }
        public string CountryName { get; init; } = string.Empty;
        public string CountryAbbreviation { get; init; } = string.Empty;
    }
}
