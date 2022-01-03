using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms.Response
{
    public class IletiMerkeziGetReportResponse
    {
        public ResponseGetReport Response { get; set; }
    }

    public class ResponseGetReport
    {
        public Status Status { get; set; }
        public OrderGetReport Order { get; set; }
    }

    public class OrderGetReport
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public IList<Message> Message { get; set; }
    }

    public class Message
    {
        public string Number { get; set; }
        public int Status { get; set; }
    }
}
