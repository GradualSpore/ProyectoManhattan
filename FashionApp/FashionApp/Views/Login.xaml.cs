using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Rg.Plugins.Popup.Services;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            btnIniciarSesion.Clicked += async (sender, e) =>
            {
                Connect login = new Connect(etyCorreo.Text, etyContra.Text);
                string error;
                if (login.Login(out error))
                {
                    if (stchRemember.IsToggled == true)
                    {
                        Preferences.Set("Login", "true");
                        Preferences.Set("Correo", etyCorreo.Text);
                        Preferences.Set("Contraseña", etyContra.Text);
                    }
                    (Application.Current).MainPage = new AppShell();
                }
<<<<<<< Updated upstream
                
                
=======
                else
                {
                    await PopupNavigation.PushAsync(new ViewGenerica());
                }
>>>>>>> Stashed changes
            };

            btnCrearCuenta.Clicked += async (sender, e) =>
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