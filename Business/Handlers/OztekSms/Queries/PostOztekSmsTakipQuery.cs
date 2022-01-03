using Business.Adapters.OztekSmsService;
using Business.BusinessAspects;
using Core.Utilities.Results;
using Entities.Dtos.OztekSms;
using MediatR;
using Refit;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.OztekSms.Queries
{
    [SecuredOperation]
    public class PostOztekSmsTakipQuery : IRequest<IDataResult<string>>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string SpecialCode { get; set; }

        public class PostOztekSms1NQueryHandler : IRequestHandler<PostOztekSmsTakipQuery, IDataResult<string>>
        {

            public async Task<IDataResult<string>> Handle(PostOztekSmsTakipQuery request, CancellationToken cancellationToken)
            {
                StringBuilder sms = new StringBuilder();
                sms.Append($"data=<sms><kulad>{request.UserName}</kulad><sifre>{request.Password}</sifre><ozelkod>{request.SpecialCode}</ozelkod></sms>");

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
