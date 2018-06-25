using Auth0XamarinForms.Core.Services.Interfaces;
using Auth0XamarinForms.Pages;
using Auth0XamarinForms.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Auth0XamarinForms.Core.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.UWP)
                LogoImage.Source = ImageSource.FromFile("Assets/MainLogo.png");
            if (Device.RuntimePlatform == Device.Android)
                LogoImage.Source = ImageSource.FromFile("MainLogo.png");
            if (Device.RuntimePlatform == Device.iOS)
                LogoImage.Source = ImageSource.FromFile("MainLogo.png");
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            var authenticationService = DependencyService.Get<IAuthenticationService>();
            var authenticationResult = await authenticationService.Authenticate();

            if (!authenticationResult.IsError)
            {
                var azureFunctionDataService = DependencyService.Get<IAzureFunctionDataService>();
                var dataFromAzureFunction = await azureFunctionDataService.GetGreeting(authenticationResult);
                if (!string.IsNullOrEmpty(dataFromAzureFunction))
                    Navigation.PushAsync(new MainPage(dataFromAzureFunction, authenticationResult));
                else
                    MainPageLabel.Text = "Cannot retrieve data from Azure Function. Please check configuration";
            }
        }
    }
}