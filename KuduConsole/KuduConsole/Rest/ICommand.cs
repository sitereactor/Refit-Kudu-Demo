using System.Threading.Tasks;
using KuduConsole.Models;
using Refit;

namespace KuduConsole.Rest
{
    public interface ICommand
    {
        [Post("/api/command")]
        Task<CommandResult> Command([Header("Authorization")] string authorization, [Body] Command body); 
    }
}