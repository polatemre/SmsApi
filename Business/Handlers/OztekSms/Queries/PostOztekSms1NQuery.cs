using Business.Adapters.OztekSmsService;
using Business.BusinessAspects;
using Core.Utilities.Results;
using MediatR;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.OztekSms.Queries
{
    [SecuredOperation]
    public class PostOztekSms1NQuery : IRequest<IDataResult<string>>
    {
        public string UserNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
        public string Numbers { get; set; }
        public string Type { get; set; }
        //public DateTime Time { get; set; }
        //public DateTime Timeout { get; set; }

        public class PostOztekSms1NQueryHandler : IRequestHandler<PostOztekSms1NQuery, IDataResult<string>>
        {

            public async Task<IDataResult<string>> Handle(PostOztekSms1NQuery request, CancellationToken cancellationToken)
            {
                StringBuilder sms = new StringBuilder();
                sms.Append($"data=<sms><kno>{request.UserNo}</kno><kulad>{request.UserName}</kulad><sifre>{request.Password}</sifre><gonderen>{request.Sender}</gonderen><tur>{request.Type}</tur><mesaj>{request.Message}</mesaj><numaralar>{request.Numbers}</numaralar></sms>");

                var service = new OztekSmsServiceManager();
                var result = await service.OztekSms1N(sms.ToString());

                if (result == null)
                {
                    return new ErrorDataResult<string>(result);
                }
                return new SuccessDataResult<string>(result);
            }
        }
    }
}
