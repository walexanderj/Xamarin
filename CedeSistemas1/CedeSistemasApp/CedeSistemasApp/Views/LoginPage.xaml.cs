using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CedeSistemasApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
#if DEBUG
            txt_email.Text = "adming@admin.com";
            txt_password.Text = "admin";
#endif
        }

        async private void btn_login_Clicked(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if(email=="adming@admin.com" && password == "admin")
            {
                //Autenticación correcta
                App.Current.MainPage = new NavigationPage (new HomePage());
                //await this.Navigation.PushModalAsync(new HomePage());
            }
            else
            {
                await this.DisplayAlert("Campos incorrectos", "Email o password incorrecto", "Aceptar");
            }
        }
    }
}