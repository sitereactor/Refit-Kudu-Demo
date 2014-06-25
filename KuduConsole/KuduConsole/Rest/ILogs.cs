using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace KuduConsole.Rest
{
    public interface ILogs
    {
        [Get("/api/logs/recent")]
        Task<HttpResponseMessage> GetLogs([Header("Authorization")] string authorization);
    }
}