using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms.Response
{
    public class IletiMerkeziSendSmsResponse : IDto
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public Status Status { get; set; }

        public Order Order { get; set; }
    }

    public class Status
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public class Order
    {
        public string Id { get; set; }
    }
}
