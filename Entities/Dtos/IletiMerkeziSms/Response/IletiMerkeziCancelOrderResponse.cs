using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms.Response
{
    public class IletiMerkeziCancelOrderResponse : IDto
    {
        public ResponseCancelOrder Response { get; set; }
    }

    public class ResponseCancelOrder
    {
        public Status Status { get; set; }
    }
}
