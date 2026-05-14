using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Gender
    {
        public required Guid GenderId { get; init; }
        public required string GenderDescription { get; init; }
    }
}
