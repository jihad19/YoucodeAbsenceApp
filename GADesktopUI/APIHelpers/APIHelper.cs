using GADesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.APIHelpers
{
    public class APIHelper : IAPIHelper
    {
        public HttpClient _apiClient;
        private ILoggedInUserModel _loggedInUserModel;

        public APIHelper(ILoggedInUserModel loggedInUserModel)
        {
            InitializeClient();
            _loggedInUserModel = loggedInUserModel;
        }


        public HttpClient ApiClient
        {
            get { return _apiClient; }
            set { _apiClient = value; }
        }

        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("ApplicationException/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
                });
            using (HttpResponseMessage response = await _apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            };
        }
        public async Task<LoggedInUserModel> GetLoggedInUserInfo(string token)
        {
            _apiClient.DefaultRequestHeaders.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer { token }");

            using (HttpResponseMessage response = await _apiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                    //LoggedInUserModel user = new LoggedInUserModel(token, result.Id, result.FirstName, result.LastName, result.EmailAddress, result.CreatedDate);
                    _loggedInUserModel.CreatedDate = result.CreatedDate;
                    _loggedInUserModel.Id = result.Id;
                    _loggedInUserModel.FirstName = result.FirstName;
                    _loggedInUserModel.LastName = result.LastName;
                    _loggedInUserModel.Token = token;
                    return result;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

