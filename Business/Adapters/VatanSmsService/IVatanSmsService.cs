using Entities.Dtos.VatanSms;
using Refit;
using System.Threading.Tasks;

namespace Business.Adapters.VatanSmsService
{
    public interface IVatanSmsService
    {
        [Post("/smsgonder1Npost.php")]
        Task<string> VatanSms1N(string vatanSms1N);

        [Post("/smsgonderNNpost.php")]
        Task<string> VatanSmsNN(string vatanSmsNN);

        [Post("/smstakippost.php")]
        Task<string> VatanSmsReport(string vatanSmsReport);
    }
}
