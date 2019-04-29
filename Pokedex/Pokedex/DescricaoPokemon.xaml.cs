using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DescricaoPokemon : ContentPage
	{
		public DescricaoPokemon (Pokemon poke)
		{
			InitializeComponent ();

            imgPokemon.Source = new UriImageSource {
                Uri = new Uri(poke.sprites.front_default),
                CachingEnabled = true
            };
            
            nomePokemon.Text = poke.name.ToUpper();
            pesoPokemon.Text = poke.weight+"pounds";
        
        }
	}
}