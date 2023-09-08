using System;
using Xamarin.Forms;

namespace healthspanmd.mobileapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Here you would typically validate the username and password against some service
            if (username == "admin" && password == "password")
            {
                await Navigation.PushAsync(new Tracker());
            }
            else
            {
                await DisplayAlert("Failure", "Invalid username or password", "OK");
            }
        }
    }
}