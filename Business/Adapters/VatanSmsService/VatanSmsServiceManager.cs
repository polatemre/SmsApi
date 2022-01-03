using Entities.Dtos.VatanSms;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.VatanSmsService
{
    public class VatanSmsServiceManager : IVatanSmsService
    {
        private readonly string apiUrl = "http://panel.vatansms.com/panel";

        public async Task<string> VatanSms1N(string vatanSms1N)
        {
            var svc = RestService.For<IVatanSmsService>(apiUrl);

            string result = string.Empty;

            await svc.VatanSms1N(vatanSms1N).ContinueWith(ret =>
            {
                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    result = ret.Result;
                }
                else
                {
                    result = "Hata";
                }
            });

            return await Task.FromResult(result);
        }

        public async Task<string> VatanSmsNN(string vatanSmsNN)
        {
            var svc = RestService.For<IVatanSmsService>(apiUrl);

            string result = string.Empty;

            await svc.VatanSmsNN(vatanSmsNN).ContinueWith(ret =>
            {
                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    result = ret.Result;
                }
                else
                {
                    result = "Hata";
                }
            });

            return await Task.FromResult(result);
        }

        public async Task<string> VatanSmsReport(string vatanSmsReport)
        {
            var svc = RestService.For<IVatanSmsService>(apiUrl);

            string result = string.Empty;

            await svc.VatanSmsReport(vatanSmsReport).ContinueWith(ret =>
            {
                if (ret.IsCompleted && ret.Status == TaskStatus.RanToCompletion)
                {
                    result = ret.Result;
                }
                else
                {
                    result = "Hata";
                }
            });

            return await Task.FromResult(result);
        }
    }
}
