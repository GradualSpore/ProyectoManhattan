using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                string correo = etyCorreo.Text;
                string contra = etyContra.Text;
                if (correo=="ja_phi" && contra=="991004ajge")
                {
                    
                    (Application.Current).MainPage = new AppShell();
                }
                else
                {
                    lblAdvertencia.Text = "Usuario o contraseña incorrectos";
                }
            };
            btnCrearCuenta.Clicked += (sender, e) =>
            {

            };
        }
    }
}