using RepeatProject.Model;
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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            Init();
        }
        // setting values to Constants page & 
        void Init()
        {
            BackgroundColor = Constants.BackgroundColour;
            Lbl_Username.TextColor = Constants.MainTextColour;
            Lbl_Password.TextColor = Constants.MainTextColour;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;


            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_SignUp_Clicked(s, e);

        }
        async void Btn_SignUp_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            // testing username and password
            if (user.CheckInformation())
            {
                //DisplayAlert("Login", "Login Success", "Okay");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login", "Login Incorrect", "Okay");
            }
        }

        async void Btn_Guest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
