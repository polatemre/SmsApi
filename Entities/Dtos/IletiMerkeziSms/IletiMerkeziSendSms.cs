using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.IletiMerkeziSms
{
    public class IletiMerkeziSendSms : IDto
    {
        public Request Request { get; set; }
    }

    public class Request
    {
        public Authentication Authentication { get; set; }
        public Order Order { get; set; }
    }

    public class Authentication
    {
        public string Key { get; set; }
        public string Hash { get; set; }
    }

    public class Order
    {
        public string Sender { get; set; }
        public IList<object> SendDateTime { get; set; }
        public string Iys { get; set; }
        public string IysList { get; set; }
        public Message Message { get; set; }
    }

    public class Message
    {
        public string Text { get; set; }
        public Receipents Receipents { get; set; }
    }

    public class Receipents
    {
        public IList<string> Number { get; set; }
    }
}
