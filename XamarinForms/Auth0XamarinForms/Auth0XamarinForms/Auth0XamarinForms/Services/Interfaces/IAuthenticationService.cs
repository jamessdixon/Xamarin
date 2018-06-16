using Auth0XamarinForms.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth0XamarinForms.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> Authenticate();
        AuthenticationResult AuthenticationResult { get; }
    }
}
