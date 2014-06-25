using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace KuduConsole.Rest
{
    public interface IDiagnostics
    {
        [Get("/api/dump")]
        Task<HttpResponseMessage> GetDump([Header("Authorization")] string authorization);
    }
}