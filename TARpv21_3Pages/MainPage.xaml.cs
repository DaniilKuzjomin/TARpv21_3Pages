using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21_3Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        List<ContentPage> contentPages = new List<ContentPage>() { new Horoscope_Page(), new Ajaplaan_Page(), new OmaPage() };
        List<string> tekstid = new List<string> { "Horoscope Page", "Ajaplaan Page", "Oma Page" };
        public MainPage()
        {
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Beige,
            };
            for (int i = 0; i < contentPages.Count; i++)
            {
                Button button = new Button
                {
                    Text = tekstid[i],
                    TabIndex = i,
                    BackgroundColor = Color.LightCyan,
                    TextColor = Color.Black
                };
                button.Clicked += Navig_funktsion;
                st.Children.Add(button);
            }
            Content = st;
        }

        private async void Navig_funktsion(object sender, EventArgs e)
        {
            Button b = (Button)sender; /// = sender as Button;
            await Navigation.PushAsync(contentPages[b.TabIndex]);
        }
    }
}
