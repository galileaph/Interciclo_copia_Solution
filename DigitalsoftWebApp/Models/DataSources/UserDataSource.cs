using DigitalsoftWebApp.Models.Account;
using Newtonsoft.Json;
using RestSharp;

namespace DigitalsoftWebApp.Models.DataSources
{
    public class UserDataSource
    {
        private readonly RestClient _client;
        private string _url_base = "https://api.digitalsoftec.net/api";
        public UserDataSource()
        {
            //_client = new RestClient(_url_base);
            //_client.AddDefaultQueryParameter("Content-Type", "application/json");
        }

        public UserDataSource(string token)
        {
            //_client = new RestClient(_url_base);
            //_client.AddDefaultQueryParameter("Accept", "application/json");
            //_client.AddDefaultQueryParameter("Authorization", "Bearer " + token);
        }

        public async Task<LoggedUser> Login(LoginUserRequest data)
        {
            //var request = new RestRequest("/user/login", Method.Post);
            //string body = JsonConvert.SerializeObject(data);
            //request.AddBody(body, ContentType.Json);
            //var response = await _client.ExecuteAsync(request);
            //if (response.StatusCode != System.Net.HttpStatusCode.OK)
            //{
            //    throw new Exception(response.ErrorMessage ?? response.Content);
            //}
            //var userResponse = LoggedUserResponse.FromJson(response.Content!);
            //LoggedUser result = LoggedUserMapper.loggedUserResponseToEntity(userResponse);
            //return result;
            return null;
        }

    }
}
