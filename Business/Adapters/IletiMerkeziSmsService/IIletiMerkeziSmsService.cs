using Entities.Dtos.IletiMerkeziSms;
using Entities.Dtos.IletiMerkeziSms.Response;
using Refit;
using System.Threading.Tasks;

namespace Business.Adapters.IletiMerkeziSmsService
{
    public interface IIletiMerkeziSmsService
    {
        [Post("/send-sms/json")]
        Task<IletiMerkeziSendSmsResponse> SendSms([Body] IletiMerkeziSendSms iletiMerkeziSendSms);

        [Post("/cancel-order/json")]
        Task<IletiMerkeziCancelOrderResponse> CancelOrder([Body] IletiMerkeziCancelOrder iletiMerkeziCancelOrder);

        [Post("/get-balance/json")]
        Task<IletiMerkeziGetBalanceResponse> GetBalance([Body] IletiMerkeziGetBalance iletiMerkeziGetBalance);

        [Post("/get-report/json")]
        Task<IletiMerkeziGetReportResponse> GetReport([Body] IletiMerkeziGetReport iletiMerkeziGetReport);
    }
}
