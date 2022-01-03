using Business.Adapters.OztekSmsService;
using Business.BusinessAspects;
using Core.Utilities.Results;
using Entities.Dtos.OztekSms;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.OztekSms.Queries
{
    [SecuredOperation]
    public class PostOztekSmsNNQuery : IRequest<IDataResult<string>>
    {
        public string UserNo { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Sender { get; set; }

        public IList<OztekSmsMessages> Messages { get; set; }

        public string Type { get; set; }

        //public DateTime Time { get; set; }

        //public DateTime Timeout { get; set; }

        public class PostOztekSmsNNQueryHandler : IRequestHandler<PostOztekSmsNNQuery, IDataResult<string>>
        {

            public async Task<IDataResult<string>> Handle(PostOztekSmsNNQuery request, CancellationToken cancellationToken)
            {
                StringBuilder sms = new StringBuilder();

                sms.Append($"data=<sms><kno>{request.UserNo}</kno><kulad>{request.UserName}</kulad><sifre>{request.Password}</sifre><gonderen>{request.Sender}</gonderen><tur>{request.Type}</tur><telmesajlar>");

                foreach (var message in request.Messages)
                {
                    sms.Append($"<telmesaj><tel>{message.Number}</tel><mesaj>{message.Message}</mesaj></telmesaj>");
                }

                sms.Append($"</telmesajlar>");

                //if(request.Time != null)
                //{
                //    sb.Append($"<zaman>{request.Time}</zaman>");
                //}

                //if (request.Timeout != null)
                //{
                //    sb.Append($"<zamanasimi>{request.Timeout}</zamanasimi>");
                //}

                sms.Append($"</sms>");

                var service = new OztekSmsServiceManager();
                var result = await service.OztekSms1N(sms.ToString());

                if (result == null)
                {
                    return new ErrorDataResult<string>();
                }
                return new SuccessDataResult<string>(result);
            }
        }
    }


}
