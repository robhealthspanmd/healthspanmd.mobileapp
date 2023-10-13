using healthspanmd.mobileapp.LocalDB;
using System;
using System.IO;
using Xamarin.Forms;

namespace healthspanmd.mobileapp
{
    public partial class MainPage : ContentPage
    {
        private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "repo.db3"));
                }

                return database;
            }
        }
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