using Xamarin.Forms;

namespace YourNamespace
{
    public partial class HealthAgeCalculator : ContentPage
    {
        public HealthAgeCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, System.EventArgs e)
        {
            // Retrieve input values from the Entry fields and the Switch
            int age = int.Parse(AgeEntry.Text);
            int waistCircumference = int.Parse(WaistCircumferenceEntry.Text);
            int aerobicActivity = int.Parse(AerobicActivityEntry.Text);
            int strengthTraining = int.Parse(StrengthTrainingEntry.Text);
            double bodyFatPercentage = double.Parse(BodyFatPercentageEntry.Text);
            int nutritionQuality = int.Parse(NutritionQualityEntry.Text);
            int sleep = int.Parse(SleepEntry.Text);
            int nonHDLCholesterol = int.Parse(NonHDLCholesterolEntry.Text);
            int systolicBP = int.Parse(SystolicBPEntry.Text);
            int diastolicBP = int.Parse(DiastolicBPEntry.Text);
            bool smoking = SmokingSwitch.IsToggled;
            double hemoglobinAlc = double.Parse(HemoglobinAlcEntry.Text);

            // Perform necessary calculations or processing using the retrieved values
            // Add logic here for calculating health age

            // Example of displaying the result in an alert
            DisplayAlert("Result", "Health age calculation result", "OK");
        }
    }
}
