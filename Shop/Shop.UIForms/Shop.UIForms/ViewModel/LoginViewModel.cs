using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.UIForms.ViewModel
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            this.Email = "irving.herreramolina@gmail.com";
            this.Password = "123456";
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an email", "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an password", "Accept");
                return;
            }

            if (!this.Email.Equals("irving.herreramolina@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "User or password wrong", "Accept");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Ok", "Fuck yeah!!", "Accept");
        }
    }
}
