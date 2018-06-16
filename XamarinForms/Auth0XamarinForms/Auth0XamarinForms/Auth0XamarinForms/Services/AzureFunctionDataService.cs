using Auth0XamarinForms.Core.Config;
using Auth0XamarinForms.Core.Model;
using Auth0XamarinForms.Core.Services;
using Auth0XamarinForms.Core.Services.Interfaces;
using Auth0XamarinForms.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AzureFunctionDataService))]
namespace Auth0XamarinForms.Core.Services
{
    public class AzureFunctionDataService : IAzureFunctionDataService
    {
        private RestClient _restClient;


        public AzureFunctionDataService()
        {
            _restClient = new RestClient(AzureConfig.AzureFunctionUrl);
        }

        public async Task<string> GetGreeting(AuthenticationResult authenticationResult)
        {
            var responseContent = string.Empty;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + authenticationResult.AccessToken);
            request.AddParameter("application/json", "{\"name\":\"Daniel\"}", ParameterType.RequestBody);
            var response = await _restClient.ExecuteTaskAsync<string>(request, default(CancellationToken));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                responseContent = response.Data;
            }

            return responseContent;
        }
    }
}
