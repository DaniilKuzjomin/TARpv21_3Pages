using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace TARpv21_3Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajaplaan_Page : ContentPage
    {
        public Ajaplaan_Page()
        {
            InitializeComponent();

            timePicker.PropertyChanged += OnTimePickerPropertyChanged;
        }

        private void OnTimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                UpdateActionLabel();
            }
        }

        private void UpdateActionLabel()
        {
            TimeSpan selectedTime = timePicker.Time;

            if (selectedTime < new TimeSpan(2, 0, 0))
            {
                actionLabel.Text = "Magamine";
                tegevusImage.Source = "sleeping.jpg";
            }
            else if (selectedTime < new TimeSpan(4, 0, 0))
            {
                actionLabel.Text = "Ärkamine";
                tegevusImage.Source = "awaking.png";
            }
            else if (selectedTime < new TimeSpan(6, 0, 0))
            {
                actionLabel.Text = "Kutsekooli sõitmine";
                tegevusImage.Source = "bus.png";
            }
            else if (selectedTime < new TimeSpan(8, 0, 0))
            {
                actionLabel.Text = "Õppimine";
                tegevusImage.Source = "books.png";
            }
            else if (selectedTime < new TimeSpan(10, 0, 0))
            {
                actionLabel.Text = "Õppimine";
                tegevusImage.Source = "books.png";
            }
            else if (selectedTime < new TimeSpan(12, 0, 0))
            {
                actionLabel.Text = "Jõusaali sõitmine";
                tegevusImage.Source = "car.png";
            }
            else if (selectedTime < new TimeSpan(14, 0, 0))
            {
                actionLabel.Text = "Sport Jõusaalis";
                tegevusImage.Source = "gym.png";
            }
            else if (selectedTime < new TimeSpan(16, 0, 0))
            {
                actionLabel.Text = "Sport jõusaalis";
                tegevusImage.Source = "gym2.png";
            }
            else if (selectedTime < new TimeSpan(18, 0, 0))
            {
                actionLabel.Text = "Kodu sõitmine";
                tegevusImage.Source = "walk.png";
            }
            else if (selectedTime < new TimeSpan(20, 0, 0))
            {
                actionLabel.Text = "Programeerimine";
                tegevusImage.Source = "programming.png";
            }
            else if (selectedTime < new TimeSpan(22, 0, 0))
            {
                actionLabel.Text = "Toiduvalmistamine";
                tegevusImage.Source = "cooking.jpg";
            }
            else
            {
                actionLabel.Text = "Puhkamine";
                tegevusImage.Source = "rest.jpg";
            }
        }
    }
}