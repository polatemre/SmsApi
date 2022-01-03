using Business.Adapters.IletiMerkeziSmsService;
using Business.BusinessAspects;
using Core.Utilities.Results;
using Entities.Dtos.IletiMerkeziSms;
using Entities.Dtos.IletiMerkeziSms.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.IletiMerkeziSms.Queries
{
    [SecuredOperation]
    public class PostIletiMerkeziSmsQuery : IRequest<IDataResult<IletiMerkeziSendSmsResponse>>
    {
        public IletiMerkeziSendSms IletiMerkeziSendSms { get; set; }

        public class PostIletiMerkeziSmsQueryHandler : IRequestHandler<PostIletiMerkeziSmsQuery, IDataResult<IletiMerkeziSendSmsResponse>>
        {
            public async Task<IDataResult<IletiMerkeziSendSmsResponse>> Handle(PostIletiMerkeziSmsQuery request, CancellationToken cancellationToken)
            {
                var service = new IletiMerkeziSmsServiceManager();
                var result = await service.SendSms(new IletiMerkeziSendSms()
                {
                    Request = request.IletiMerkeziSendSms.Request
                });

                if (result == null)
                {
                    return new ErrorDataResult<IletiMerkeziSendSmsResponse>(result);
                }
                return new SuccessDataResult<IletiMerkeziSendSmsResponse>(result);
            }
        }
    }
}
