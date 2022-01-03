using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Dtos.VatanSms
{
    public class VatanSmsNN : IDto
    {
        public string UserNo { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Sender { get; set; }

        public IList<VatanSmsMessages> Messages { get; set; }

        public string Type { get; set; }

        public DateTime Time { get; set; }

        public DateTime Timeout { get; set; }
    }

    public class VatanSmsMessages
    {
        public string Number { get; set; }

        public string Message { get; set; }
    }
}
