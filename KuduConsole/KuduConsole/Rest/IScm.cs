using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace KuduConsole.Rest
{
    public interface IScm
    {
        [Get("/api/scm/info")]
        Task<HttpResponseMessage> GetInformation([Header("Authorization")] string authorization);

        [Post("/api/scm/clean")]
        Task<HttpResponseMessage> CleanRepository([Header("Authorization")] string authorization);

        [Delete("/api/scm")]
        Task<HttpResponseMessage> DeleteRepository([Header("Authorization")] string authorization);
    }
}
