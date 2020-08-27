using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> AllCategories { get => GetCategories(); }

        private List<Category> GetCategories()
        {
            var catList = new List<Category>();
            catList.Add(new Category { Image = "summerCol.png", Title = "Italiana", Caption = "PASTA, PIZZA, ETC" });
            catList.Add(new Category { Image = "dressShoe.png", Title = "Saludable", Caption = "COMIDA SANA SIN EXCESOS" });
            catList.Add(new Category { Image = "satchel.png", Title = "Comida Rapida", Caption = "RESTAURANTES DE COMIDA RAPIDA" });
            return catList;
        }
    }
}