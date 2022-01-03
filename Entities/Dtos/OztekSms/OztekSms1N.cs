using Core.Entities;
using System;

namespace Entities.Dtos.OztekSms
{
    public class OztekSms1N : IDto
    {
        public string UserNo { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Sender { get; set; }

        public string Message { get; set; }

        public string Numbers { get; set; }

        public string Type { get; set; }

        public DateTime Time { get; set; }

        public DateTime Timeout { get; set; }
    }
}