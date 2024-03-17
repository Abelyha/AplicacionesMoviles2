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
    public partial class AddPage : ContentPage
    {
        public IList<Departamento> Departamentos { get; private set; }

        public AddPage()
        {
            InitializeComponent();
            { 

            Departamentos = new List<Departamento>();

            Departamentos.Add(new Departamento
            {
                Name = "Arequipa",
                Ubication = "Sur",
                Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

            });

            Departamentos.Add(new Departamento
            {
                Name = "Cuzco",
                Ubication = "Sur",
                Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

            });

            Departamentos.Add(new Departamento
            {
                Name = "Piura",
                Ubication = "Norte",
                Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

            });

            Departamentos.Add(new Departamento
            {
                Name = "Tumbes",
                Ubication = "Norte",
                Url = "<https://cdn0.geoenciclopedia.com/es/posts/8/9/4/estados_de_mexico_y_sus_capitales_498_orig.jpg>"

            });
            BindingContext = this;
        }
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Departamento selectedItem = e.SelectedItem as Departamento;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Departamento tappedItem = e.Item as Departamento;
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
    }

}