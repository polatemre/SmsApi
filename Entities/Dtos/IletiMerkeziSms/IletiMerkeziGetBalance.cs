using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms
{
    public class IletiMerkeziGetBalance : IDto
    {
        public RequestGetBalance Request { get; set; }
    }

    public class RequestGetBalance
    {
        public Authentication Authentication { get; set; }
    }
}
