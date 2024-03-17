using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacion1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public IList<Distrito> Distritos { get; private set; }

        public Page3()
        {
            InitializeComponent();
            {
                Distritos = new List<Distrito>();

                Distritos.Add(new Distrito
                {
                    Name = "Alto Selva Alegre",
                    Ubication = "",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Distritos.Add(new Distrito
                {
                    Name = "Cayma",
                    Ubication = "",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Distritos.Add(new Distrito
                {
                    Name = "Characato",
                    Ubication = "",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });

                Distritos.Add(new Distrito
                {
                    Name = "Cerro Colorado",
                    Ubication = "",
                    Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

                });
                BindingContext = this;
            }
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Distrito selectedItem = e.SelectedItem as Distrito;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Distrito tappedItem = e.Item as Distrito;
        }
    }
}