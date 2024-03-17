using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacion1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public IList<Pais> Paises { get; private set; }

        public Inicio()
        {
            InitializeComponent();
            {
                Paises = new List<Pais>();

                Paises.Add(new Pais
                {
                    Name = "Mexico",
                    Ubication = "Norte",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Paises.Add(new Pais
                {
                    Name = "Chile",
                    Ubication = "Sur",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Paises.Add(new Pais
                {
                    Name = "Brasil",
                    Ubication = "Sur",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Paises.Add(new Pais
                {
                    Name = "Colombia",
                    Ubication = "Sur",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });
                BindingContext = this;

            }
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Pais selectedItem = e.SelectedItem as Pais;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Pais tappedItem = e.Item as Pais;
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
        async void ToolbarItem_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}