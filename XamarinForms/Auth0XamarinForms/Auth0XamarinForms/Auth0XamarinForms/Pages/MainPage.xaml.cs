using Auth0XamarinForms.Core.Model;
using Auth0XamarinForms.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Auth0XamarinForms.Pages
{
	public partial class MainPage : ContentPage
	{
		public MainPage(string greetingFromAzureFunction, AuthenticationResult authenticationResult)
		{
			InitializeComponent();
            GreetingLabel.Text = greetingFromAzureFunction;
            UserImage.Source = authenticationResult.UserClaims.FirstOrDefault(c => c.Type == "picture")?.Value;
        }
    }
}
