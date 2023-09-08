using System;
using Xamarin.Forms;

namespace healthspanmd.mobileapp
{
    public partial class Tracker : ContentPage
    {
        public Tracker()
        {
            InitializeComponent();
        }

        async void OnSaveDataClicked(object sender, EventArgs e)
        {
            string weight = weightEntry.Text;
            string bloodPressure = bloodPressureEntry.Text;
            string exerciseMinutes = exerciseMinutesEntry.Text;

            // Here, you would typically store these values, possibly by sending them to a server
            await DisplayAlert("Data Saved", "Your health data has been saved.", "OK");
        }
    }
}