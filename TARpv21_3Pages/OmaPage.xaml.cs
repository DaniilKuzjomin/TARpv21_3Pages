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
        private DateTime[] _dateTimes;
        private TimePicker[] _timePickers;
        private Label _totalTimeLabel;

        public OmaPage()
        {
            _dateTimes = new DateTime[2];
            _timePickers = new TimePicker[2];


            for (int i = 0; i < _timePickers.Length; i++)
            {
                _dateTimes[i] = DateTime.Now.Date;
                _timePickers[i] = new TimePicker
                {
                    Format = "HH:mm",
                    Time = DateTime.Now.TimeOfDay
                };
                _timePickers[i].PropertyChanged += OnTimePickerPropertyChanged;
            }

            _totalTimeLabel = new Label
            {
                Text = "Выберите дату, время начала и окончания занятий"
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Дата начала занятий:" },
                    new DatePicker { Date = _dateTimes[0] },
                    new Label { Text = "Время начала занятий:" },
                    _timePickers[0],
                    new Label { Text = "Дата окончания занятий:" },
                    new DatePicker { Date = _dateTimes[1] },
                    new Label { Text = "Время окончания занятий:" },
                    _timePickers[1],
                    _totalTimeLabel
                }
            };
        }

        private void OnTimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {

                TimeSpan studyTime = (_dateTimes[1] + _timePickers[1].Time) - (_dateTimes[0] + _timePickers[0].Time);


                _totalTimeLabel.Text = $"Общее время занятий: {studyTime.TotalHours} часов {studyTime.Minutes} минут";
            }
        }
    }
}