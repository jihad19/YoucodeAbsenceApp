using GADesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace GADesktopUI.APIHelpers
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; set; }

        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
        Task RegisterSecretary(string email, string username, string password, string ConfirmPassword);
        Task RegisterFormer(string email, string username, string password, string ConfirmPassword);
        Task RegisterStudent(string email, string username, string password, string ConfirmPassword,string class_id);
    }
}