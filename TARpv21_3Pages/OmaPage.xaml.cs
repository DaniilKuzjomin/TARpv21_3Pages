using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_3Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OmaPage : ContentPage
    {
        private TimePicker[] _timePickers;
        private Label _totalTimeLabel;

        public OmaPage()
        {

            _timePickers = new TimePicker[2];


            for (int i = 0; i < _timePickers.Length; i++)
            {
                _timePickers[i] = new TimePicker
                {
                    Format = "HH:mm",
                    Time = DateTime.Now.TimeOfDay
                };
                _timePickers[i].PropertyChanged += OnTimePickerPropertyChanged;
            }

            _totalTimeLabel = new Label
            {
                Text = "Vali lõpp ja alguse aeg"
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Algusaeg:" },
                    _timePickers[0],
                    new Label { Text = "Lõppaeg:" },
                    _timePickers[1],
                    _totalTimeLabel
                }
            };
        }

        private void OnTimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {

                TimeSpan studyTime = _timePickers[1].Time - _timePickers[0].Time;


                _totalTimeLabel.Text = $"Kokku: {studyTime.TotalHours} tundi ja {studyTime.Minutes} minutit";
            }
        }
    }
}