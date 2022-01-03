using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms.Response
{
    public class IletiMerkeziGetBalanceResponse : IDto
    {
        public Response Response { get; set; }
    }

    public class ResponseGetBalance
    {
        public Status Status { get; set; }

        public Balance Balance { get; set; }
    }

    public class Balance
    {
        public string Amount { get; set; }
        public string Sms { get; set; }
    }
}
