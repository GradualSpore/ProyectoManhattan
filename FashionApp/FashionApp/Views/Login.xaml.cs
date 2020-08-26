using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            btnIniciarSesion.Clicked += (sender, e) =>
            {
                if ("root"==etyCorreo.Text && "12345"==etyContra.Text)
                {
                    if (stchRemember.IsToggled == true)
                    {
                        Preferences.Set("Login", "true");
                        Preferences.Set("Correo", etyCorreo.Text);
                        Preferences.Set("Contraseña", etyContra.Text);
                    }
                    (Application.Current).MainPage = new AppShell();
                }
                else
                {
                    lblAdvertencia.Text = "Usuario o contraseña incorrectos";
                }
            };
            btnCrearCuenta.Clicked += async(sender, e) =>
            {
                await Navigation.PushAsync(new Registro());
            };
        }
        protected override void OnAppearing()
        {
            if ((Preferences.ContainsKey("Login", "true") == true))
            {
                etyCorreo.Text = Preferences.Get("Correo", "");
                etyContra.Text = Preferences.Get("Contraseña", "");
                stchRemember.IsToggled = true;
            }
        }

    }
}