using Core.Entities;
using System.Collections.Generic;

namespace Entities.Dtos.OztekSms
{
    public class OztekSmsReport : IDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string SpecialCode { get; set; }
    }
}
