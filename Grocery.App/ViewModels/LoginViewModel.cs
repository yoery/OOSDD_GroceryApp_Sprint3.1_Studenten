using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views; // Zorg dat deze using klopt
// Voeg eventueel ook Grocery.App toe als je AppShell daar staat

namespace Grocery.App.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty] string username;
        [ObservableProperty] string password;
        [ObservableProperty] string message;

        [RelayCommand]
        private async Task Login()
        {
            if (AccountService.ValidateAccount(Username, Password))
            {
                // Navigeer naar het hoofdscherm via AppShell
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                Message = "Ongeldige gebruikersnaam of wachtwoord.";
            }
        }

        [RelayCommand]
        private async Task NavigateToRegister()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Registerpage());
        }
    }
}
