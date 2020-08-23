using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Timer timer;
        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> CollectionsList { get => GetCollections(); }
        public List<Product> TrendsList { get => GetTrends(); }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "BEBIDAS", Message = "40% Descuento", Caption = "EN NUESTRA GRAN SELECCION DE BEBIDAS", Image = "classic.png" });
            bannerList.Add(new Banner { Heading = "RESTAURANTES", Message = "Hasta 50% de rebaja", Caption = "EN PLATILLOS PRINCIPALES", Image = "womenCol.png" });
            bannerList.Add(new Banner { Heading = "POSTRES", Message = "20% Descuento", Caption = "EN BEBIDAS FRIAS", Image = "elegantCol.png" });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "coats.png", Name = "Comida X", Price = "$123.50" });
            
            trendList.Add(new Product { Image = "coats.png", Name = "Comida X", Price = "$123.50" });
            trendList.Add(new Product { Image = "coats2.png", Name = "Comida Y", Price = "200" });


            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "coats.png", Name = "Platillo X", Price = "$109.99" });
            colList.Add(new Product { Image = "coats.png", Name = "Platillo X", Price = "$109.99" });
            return colList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }
    }

    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}