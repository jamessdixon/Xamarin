using MvvmCrossDemo.Core.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossDemo.Core.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool LoggedIn { get; set; }

        public bool IsLoggedIn()
        {
            return LoggedIn;
        }
    }
}
