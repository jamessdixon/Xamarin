using Auth0XamarinForms.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth0XamarinForms.Core.Services.Interfaces
{
    public interface IAzureFunctionDataService
    {
        Task<string> GetGreeting(AuthenticationResult authenticationResult);
    }
}
