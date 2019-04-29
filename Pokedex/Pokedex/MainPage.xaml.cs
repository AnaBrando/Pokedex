using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokedex
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            logoPokemon.Source = new UriImageSource { Uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/International_Pok%C3%A9mon_logo.svg/640px-International_Pok%C3%A9mon_logo.svg.png") };
            
        }

        public async void PesquisarPokemon(object sender, EventArgs e) {

            HttpClient client = new HttpClient();


            var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + txtPesquisaPokemon.Text);
            if(response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                Pokemon resultado = JsonConvert.DeserializeObject<Pokemon>(content);
                await Navigation.PushModalAsync(new DescricaoPokemon(resultado));
                

            }


        }
    }
}
