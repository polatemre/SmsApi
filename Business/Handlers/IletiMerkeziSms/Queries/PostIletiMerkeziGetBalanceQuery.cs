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
    public class PostIletiMerkeziGetBalanceQuery : IRequest<IDataResult<IletiMerkeziGetBalanceResponse>>
    {
        public IletiMerkeziGetBalance IletiMerkeziGetBalance { get; set; }

        public class PostIletiMerkeziGetBalanceQueryHandler : IRequestHandler<PostIletiMerkeziGetBalanceQuery, IDataResult<IletiMerkeziGetBalanceResponse>>
        {
            public async Task<IDataResult<IletiMerkeziGetBalanceResponse>> Handle(PostIletiMerkeziGetBalanceQuery request, CancellationToken cancellationToken)
            {
                var service = new IletiMerkeziSmsServiceManager();
                var result = await service.GetBalance(new IletiMerkeziGetBalance()
                {
                    Request = request.IletiMerkeziGetBalance.Request
                });

                if (result == null)
                {
                    return new ErrorDataResult<IletiMerkeziGetBalanceResponse>(result);
                }
                return new SuccessDataResult<IletiMerkeziGetBalanceResponse>(result);
            }
        }
    }
}
