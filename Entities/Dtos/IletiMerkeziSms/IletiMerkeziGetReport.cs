using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms
{
    public class IletiMerkeziGetReport : IDto
    {
        public RequestGetReport Request { get; set; }
    }

    public class RequestGetReport
    {
        public Authentication Authentication { get; set; }
        public OrderGetReport Order { get; set; }
    }

    public class OrderGetReport
    {
        public string Id { get; set; }
        public string Page { get; set; }
        public string RowCount { get; set; }
    }
}
