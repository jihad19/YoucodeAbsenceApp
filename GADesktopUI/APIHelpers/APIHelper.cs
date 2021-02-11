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
        public async Task GetLoggedInUserInfo(string token)
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
                    _loggedInUserModel.CreatedDate = result.CreatedDate;
                    _loggedInUserModel.user_Id = result.user_Id;
                    _loggedInUserModel.FirstName = result.FirstName;
                    _loggedInUserModel.LastName = result.LastName;
                    _loggedInUserModel.Token = token;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public async Task RegisterSecretary(string email, string username, string password, string ConfirmPassword)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Email", "loubnayat3@youcode.com"),
                new KeyValuePair<string, string>("UserName", "loubnaaa loubnaaa"),
                new KeyValuePair<string, string>("Password", "Pwordd_123"),
                new KeyValuePair<string, string>("ConfirmPassword", "Pwordd_123")
                });
            using (HttpResponseMessage response = await _apiClient.PostAsync("api/account/registerSecretary", data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }


            };
        }
        public async Task RegisterFormer(string email, string username, string password, string ConfirmPassword)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                 new KeyValuePair<string, string>("Email", email),
                new KeyValuePair<string, string>("UserName", username),
                new KeyValuePair<string, string>("Password", password),
                new KeyValuePair<string, string>("ConfirmPassword", "ConfirmPassword")
                });
            using (HttpResponseMessage response = await _apiClient.PostAsync("api/account/registerFormer", data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

            };
        }
        public async Task RegisterStudent(string email,string username,string password,string ConfirmPassword,string class_id)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Email", email),
                new KeyValuePair<string, string>("UserName", username),
                new KeyValuePair<string, string>("class", class_id),
                new KeyValuePair<string, string>("Password", password),
                new KeyValuePair<string, string>("ConfirmPassword", ConfirmPassword)
                });
            using (HttpResponseMessage response = await _apiClient.PostAsync("api/account/registerStudent", data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }

            };
        }
        public void LogOffUser()
        {
            _apiClient.DefaultRequestHeaders.Clear();
        }
    }
}

