using System.Net.Http;
using System.Threading.Tasks;

namespace PluginWebRequest.API.Factory
{
    public interface IApiClient
    {
        Task TestConnection();
        Task<HttpResponseMessage> GetAsync(string path);
        Task<HttpResponseMessage> PostAsync(string path, StringContent json);
        Task<HttpResponseMessage> PutAsync(string path, StringContent json);
        Task<HttpResponseMessage> PatchAsync(string path, StringContent json);
        Task<HttpResponseMessage> DeleteAsync(string path);
    }
}