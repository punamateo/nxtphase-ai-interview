using System.Threading.Tasks;

namespace QueryAPI.Services
{
    public interface ILlmService
    {
        Task<string> GenerateResponseAsync(string query);
    }
}
