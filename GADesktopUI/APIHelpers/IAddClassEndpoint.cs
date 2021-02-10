using GADesktopUI.Models;
using System.Threading.Tasks;

namespace GADesktopUI.APIHelpers
{
    public interface IAddClassEndpoint
    {
        Task PostAddClass(AddClassModel Class);
        Task UpdateUser(UpdateUserModel user);
    }
}