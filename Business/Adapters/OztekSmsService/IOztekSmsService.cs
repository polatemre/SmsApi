using Refit;
using System.Threading.Tasks;

namespace Business.Adapters.OztekSmsService
{
    public interface IOztekSmsService
    {
        [Post("/smsgonder1Npost.php")]
        Task<string> OztekSms1N(string OztekSms1N);

        [Post("/smsgonderNNpost.php")]
        Task<string> OztekSmsNN(string OztekSmsNN);

        [Post("/smstakippost.php")]
        Task<string> OztekSmsReport(string OztekSmsReport);
    }
}
