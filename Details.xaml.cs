using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Details : ContentPage
	{
		public Details ()
		{
			InitializeComponent ();
		}
        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }
    }
}