using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace KuduConsole.Rest
{
    public interface ISiteExtensions
    {
        [Get("/api/extensionfeed")]
        Task<HttpResponseMessage> GetAllExtensions([Header("Authorization")] string authorization);

        [Get("/api/siteextensions")]
        Task<HttpResponseMessage> GetInstalledExtensions([Header("Authorization")] string authorization);

        [Get("/api/extensionfeed/{id}")]
        Task<HttpResponseMessage> GetPackageInfo([Header("Authorization")] string authorization, string id);

        [Get("/api/siteextensions/{id}")]
        Task<HttpResponseMessage> GetInstalledPackageInfo([Header("Authorization")] string authorization, string id);

        [Put("/api/siteextensions/{id}")]
        Task<HttpResponseMessage> InstallPackage([Header("Authorization")] string authorization, string id, object payload);

        [Delete("/api/siteextensions/{id}")]
        Task<HttpResponseMessage> UninstallPackage([Header("Authorization")] string authorization, string id);
    }
}