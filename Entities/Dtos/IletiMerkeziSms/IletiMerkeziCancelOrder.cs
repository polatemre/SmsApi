using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms
{
    public class IletiMerkeziCancelOrder : IDto
    {
        public RequestCancelOrder Request { get; set; }
    }

    public class RequestCancelOrder
    {
        public Authentication Authentication { get; set; }
        public OrderCancelOrder Order { get; set; }
    }

    public class OrderCancelOrder
    {
        public string Id { get; set; }
    }
}
