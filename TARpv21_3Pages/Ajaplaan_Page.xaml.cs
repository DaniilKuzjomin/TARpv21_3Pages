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
        private Dictionary<TimeSpan, (string, string)> _timeActions;

        public Ajaplaan_Page()
        {
            InitializeComponent();

            timePicker.PropertyChanged += ChangedTime;

            _timeActions = new Dictionary<TimeSpan, (string, string)>
            {
                { new TimeSpan(0, 0, 0), ("Magamine", "sleeping.jpg") },
                { new TimeSpan(7, 30, 0), ("Ärkamine", "awaking.png") },
                { new TimeSpan(8, 0, 0), ("Kutsekooli sõitmine", "bus.png") },
                { new TimeSpan(8, 30, 0), ("Õppimine", "books.png") },
                { new TimeSpan(14, 0, 0), ("Õppimine", "books.png") },
                { new TimeSpan(15, 0, 0), ("Jõusaali sõitmine", "car.png") },
                { new TimeSpan(16, 0, 0), ("Sport Jõusaalis", "gym.png") },
                { new TimeSpan(17, 0, 0), ("Sport jõusaalis", "gym2.png") },
                { new TimeSpan(18, 0, 0), ("Kodu sõitmine", "walk.png") },
                { new TimeSpan(19, 0, 0), ("Programeerimine", "programming.png") },
                { new TimeSpan(20, 0, 0), ("Toiduvalmistamine", "cooking.jpg") },
                { new TimeSpan(23, 59, 59), ("Puhkamine", "rest.jpg") }
            };
        }

        private void ChangedTime(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                MuutaLI();
            }
        }

        private void MuutaLI()
        {
            TimeSpan selectedTime = timePicker.Time;
            (string action, string image) = _timeActions[selectedTime];

            actionLabel.Text = action;
            tegevusImage.Source = image;
        }
    }
}