using Business.Adapters.VatanSmsService;
using Business.BusinessAspects;
using Core.Utilities.Results;
using Entities.Dtos.VatanSms;
using MediatR;
using Refit;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.VatanSms.Queries
{
    [SecuredOperation]
    public class PostVatanSmsTakipQuery : IRequest<IDataResult<string>>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string SpecialCode { get; set; }

        public class PostVatanSms1NQueryHandler : IRequestHandler<PostVatanSmsTakipQuery, IDataResult<string>>
        {

            public async Task<IDataResult<string>> Handle(PostVatanSmsTakipQuery request, CancellationToken cancellationToken)
            {
                StringBuilder sms = new StringBuilder();
                sms.Append($"data=<sms><kulad>{request.UserName}</kulad><sifre>{request.Password}</sifre><ozelkod>{request.SpecialCode}</ozelkod></sms>");

                var service = new VatanSmsServiceManager();
                var result = await service.VatanSms1N(sms.ToString());

                if (result == null)
                {
                    return new ErrorDataResult<string>(result);
                }
                return new SuccessDataResult<string>(result);
            }
        }
    }


}
