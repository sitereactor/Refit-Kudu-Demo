using System.Collections.Generic;
using System.Threading.Tasks;
using KuduConsole.Models;
using Refit;

namespace KuduConsole.Rest
{
    public interface IDeployment
    {
        [Get("/api/deployments")]
        Task<IEnumerable<Deployment>> GetDeployments([Header("Authorization")] string authorization);

        [Get("/api/deployments/{id}")]
        Task<Deployment> GetDeployment([Header("Authorization")] string authorization, string id);

        [Put("/api/deployments/{id}")]
        Task DeployPrevious([Header("Authorization")] string authorization, string id, [Body] string body);

        [Put("/api/deployments")]
        Task DeployCurrent([Header("Authorization")] string authorization, [Body] object body);

        [Delete("/api/deployments/{id}")]
        Task DeleteDeployment([Header("Authorization")] string authorization, string id);

        [Get("/api/deployments/{id}/log")]
        Task<IEnumerable<DeploymentLog>> GetDeploymentLogs([Header("Authorization")] string authorization, string id);

        [Get("/api/deployments/{id}/log/{logId}")]
        Task<DeploymentLog> GetDeploymentLog([Header("Authorization")] string authorization, string id, string logId);
    }
}