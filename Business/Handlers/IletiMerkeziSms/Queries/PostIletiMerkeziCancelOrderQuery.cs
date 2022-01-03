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
    public class PostIletiMerkeziCancelOrderQuery : IRequest<IDataResult<IletiMerkeziCancelOrderResponse>>
    {
        public IletiMerkeziCancelOrder IletiMerkeziCancelOrder { get; set; }

        public class PostIletiMerkeziCancelOrderQueryHandler : IRequestHandler<PostIletiMerkeziCancelOrderQuery, IDataResult<IletiMerkeziCancelOrderResponse>>
        {
            public async Task<IDataResult<IletiMerkeziCancelOrderResponse>> Handle(PostIletiMerkeziCancelOrderQuery request, CancellationToken cancellationToken)
            {
                var service = new IletiMerkeziSmsServiceManager();
                var result = await service.CancelOrder(new IletiMerkeziCancelOrder()
                {
                    Request = request.IletiMerkeziCancelOrder.Request
                });

                if (result == null)
                {
                    return new ErrorDataResult<IletiMerkeziCancelOrderResponse>(result);
                }
                return new SuccessDataResult<IletiMerkeziCancelOrderResponse>(result);
            }
        }
    }
}
