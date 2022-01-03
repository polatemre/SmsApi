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
    public class PostIletiMerkeziGetReportQuery : IRequest<IDataResult<IletiMerkeziGetReportResponse>>
    {
        public IletiMerkeziGetReport IletiMerkeziGetReport { get; set; }

        public class PostIletiMerkeziGetReportQueryHandler : IRequestHandler<PostIletiMerkeziGetReportQuery, IDataResult<IletiMerkeziGetReportResponse>>
        {
            public async Task<IDataResult<IletiMerkeziGetReportResponse>> Handle(PostIletiMerkeziGetReportQuery request, CancellationToken cancellationToken)
            {
                var service = new IletiMerkeziSmsServiceManager();
                var result = await service.GetReport(new IletiMerkeziGetReport()
                {
                    Request = request.IletiMerkeziGetReport.Request
                });

                if (result == null)
                {
                    return new ErrorDataResult<IletiMerkeziGetReportResponse>(result);
                }
                return new SuccessDataResult<IletiMerkeziGetReportResponse>(result);
            }
        }
    }
}
