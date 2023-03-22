using System;
using Xamarin.Forms;

namespace TARpv21_3Pages
{
    public partial class Horoscope_Page : ContentPage
    {
        public Horoscope_Page()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime birthdate = e.NewDate;
            string horoscope = CalculateHoroscope(birthdate);
            horoscopeLabel.Text = $"Sinu sodiaagimärk: {horoscope}";
        }


        private string CalculateHoroscope(DateTime birthdate)
        {
            string[] signs = { "Jäär", "Sõnn", "Kaksikud", "Vähk", "Lõvi", "Neitsi", "Kaalud", "Skorpion", "Ambur", "Kaljukits", "Veevalaja", "Kalad" };
            int[] cutoffDays = { 20, 21, 21, 21, 22, 22, 23, 23, 22, 22, 21, 20 };
            int birthMonth = birthdate.Month;
            int birthDay = birthdate.Day;

            int signIndex = birthMonth - 4;
            if (birthDay > cutoffDays[signIndex])
            {
                signIndex = (signIndex + 1) % 12;
            }

            switch (signs[signIndex])
            {
                case "Jäär":
                    horoscopeImage.Source = "aries.PNG";
                    return "Jäär (21. märts - 20. aprill)";
                case "Sõnn":
                    horoscopeImage.Source = "taurus.PNG";
                    return "Sõnn (21. aprill - 21. mai)";
                case "Kaksikud":
                    horoscopeImage.Source = "gemini.PNG";
                    return "Kaksikud (22. mai - 21. juuni)";
                case "Vähk":
                    horoscopeImage.Source = "cancer.PNG";
                    return "Vähk (22. juuni - 22. juuli)";
                case "Lõvi":
                    horoscopeImage.Source = "leo.PNG";
                    return "Lõvi (23. juuli - 22. august)";
                case "Neitsi":
                    horoscopeImage.Source = "virgo.PNG";
                    return "Neitsi (23. august - 22. september)";
                case "Kaalud":
                    horoscopeImage.Source = "libra.PNG";
                    return "Kaalud (23. september - 23. oktoober)";
                case "Skorpion":
                    horoscopeImage.Source = "scorpio.PNG";
                    return "Skorpion (24. oktoober - 22. november)";
                case "Ambur":
                    horoscopeImage.Source = "sagittarius.PNG";
                    return "Ambur (23. november - 21. detsember)";
                case "Kaljukits":
                    horoscopeImage.Source = "capricorn.PNG";
                    return "Kaljukits (22. detsember - 20. jaanuar)";
                case "Veevalaja":
                    horoscopeImage.Source = "aquarius.PNG";
                    return "Veevalaja (21. jaanuar - 18. veebruar)";
                case "Kalad":
                    horoscopeImage.Source = "pisces.PNG";
                    return "Kalad (19. veebruar - 20. märts)";
                default:
                    horoscopeImage.Source = "";
                    return "";
            }
        }
    }
}
