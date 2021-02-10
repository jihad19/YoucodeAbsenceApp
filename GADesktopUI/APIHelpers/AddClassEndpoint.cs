using GADesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.APIHelpers
{
    public class AddClassEndpoint : IAddClassEndpoint
    {
        private IAPIHelper _apiHelper;

        public AddClassEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task PostAddClass(AddClassModel Class)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/AdmAddClass", Class))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
        public async Task UpdateUser(UpdateUserModel user)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/AdmUpdateUser", user))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
        
    }
}
