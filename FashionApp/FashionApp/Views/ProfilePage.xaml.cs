using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            btnLogOut.Clicked += BtnLogOut_Clicked;

        }

        private void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("Login");
            Preferences.Remove("Correo");
            Preferences.Remove("Contraseña");
        }
    }
}