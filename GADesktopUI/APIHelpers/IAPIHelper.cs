using GADesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace GADesktopUI.APIHelpers
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; set;}

        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}