using Entities.Dtos.OztekSms;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.OztekSmsService
{
    public class OztekSmsServiceManager : IOztekSmsService
    {
        private readonly string apiUrl = "https://www.ozteksms.com/panel";

        public async Task<string> OztekSms1N(string OztekSms1N)
        {
            var svc = RestService.For<IOztekSmsService>(apiUrl);

            string result = string.Empty;

            await svc.OztekSms1N(OztekSms1N).ContinueWith(ret =>
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

        public async Task<string> OztekSmsNN(string OztekSmsNN)
        {
            var svc = RestService.For<IOztekSmsService>(apiUrl);

            string result = string.Empty;

            await svc.OztekSmsNN(OztekSmsNN).ContinueWith(ret =>
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

        public async Task<string> OztekSmsReport(string OztekSmsReport)
        {
            var svc = RestService.For<IOztekSmsService>(apiUrl);

            string result = string.Empty;

            await svc.OztekSmsReport(OztekSmsReport).ContinueWith(ret =>
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
