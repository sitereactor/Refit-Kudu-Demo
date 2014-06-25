using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace KuduConsole.Rest
{
    public interface IDiagnosticsSettings
    {
        [Post("/api/diagnostics/settings")]
        Task<HttpResponseMessage> UpdateSettings([Header("Authorization")] string authorization);

        [Get("/api/diagnostics/settings")]
        Task<HttpResponseMessage> GetSettings([Header("Authorization")] string authorization);

        [Get("/api/diagnostics/settings{key}")]
        Task<HttpResponseMessage> GetSetting([Header("Authorization")] string authorization, string key);

        [Delete("/api/diagnostics/settings{key}")]
        Task<HttpResponseMessage> DeleteSetting([Header("Authorization")] string authorization, string key);
    }
}