using Entities.Dtos.IletiMerkeziSms;
using Entities.Dtos.IletiMerkeziSms.Response;
using Refit;
using System.Threading.Tasks;

namespace Business.Adapters.IletiMerkeziSmsService
{
    public class IletiMerkeziSmsServiceManager : IIletiMerkeziSmsService
    {
        private readonly string apiUrl = "https://api.iletimerkezi.com/v1";

        public async Task<IletiMerkeziCancelOrderResponse> CancelOrder(IletiMerkeziCancelOrder iletiMerkeziCancelOrder)
        {
            var svc = RestService.For<IIletiMerkeziSmsService>(apiUrl);

            IletiMerkeziCancelOrderResponse response = new IletiMerkeziCancelOrderResponse();

            await svc.CancelOrder(iletiMerkeziCancelOrder).ContinueWith(ret =>
            {

                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    response = ret.Result;
                }

                else
                {
                    var status = Newtonsoft.Json.JsonConvert.DeserializeObject<IletiMerkeziCancelOrderResponse>(((ApiException)ret.Exception.InnerException).Content);
                    response = status;
                }
            });

            return await Task.FromResult(response);
        }

        public async Task<IletiMerkeziGetBalanceResponse> GetBalance([Body] IletiMerkeziGetBalance iletiMerkeziGetBalance)
        {
            var svc = RestService.For<IIletiMerkeziSmsService>(apiUrl);

            IletiMerkeziGetBalanceResponse response = new IletiMerkeziGetBalanceResponse();

            await svc.GetBalance(iletiMerkeziGetBalance).ContinueWith(ret =>
            {

                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    response = ret.Result;
                }

                else
                {
                    var status = Newtonsoft.Json.JsonConvert.DeserializeObject<IletiMerkeziGetBalanceResponse>(((ApiException)ret.Exception.InnerException).Content);
                    response = status;
                }
            });

            return await Task.FromResult(response);
        }

        public async Task<IletiMerkeziGetReportResponse> GetReport([Body] IletiMerkeziGetReport iletiMerkeziGetReport)
        {
            var svc = RestService.For<IIletiMerkeziSmsService>(apiUrl);

            IletiMerkeziGetReportResponse response = new IletiMerkeziGetReportResponse();

            await svc.GetReport(iletiMerkeziGetReport).ContinueWith(ret =>
            {
                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    response = ret.Result;
                }

                else
                {
                    var status = Newtonsoft.Json.JsonConvert.DeserializeObject<IletiMerkeziGetReportResponse>(((ApiException)ret.Exception.InnerException).Content);
                    response = status;
                }
            });

            return await Task.FromResult(response);
        }

        public async Task<IletiMerkeziSendSmsResponse> SendSms(IletiMerkeziSendSms iletiMerkeziSendSms)
        {
            var svc = RestService.For<IIletiMerkeziSmsService>(apiUrl);

            IletiMerkeziSendSmsResponse response = new IletiMerkeziSendSmsResponse();

            await svc.SendSms(iletiMerkeziSendSms).ContinueWith(ret =>
            {

                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    response = ret.Result;
                }
                else
                {
                    var status = Newtonsoft.Json.JsonConvert.DeserializeObject<IletiMerkeziSendSmsResponse>(((ApiException)ret.Exception.InnerException).Content);
                    response = status;
                }

            });

            return await Task.FromResult(response);
        }
    }
}
