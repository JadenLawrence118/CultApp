using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CultApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public string[] images = { "placeholderImage.png", "placeholder2.png", "real1.png", "real2.png", "real3.png", "real4.png" };
        public int counter1 = 0;
        public int counter2 = 0;
        public int counter3 = 0;
        public int counter4 = 0;
        public bool allCorrect = false;

        private void Btn1_Clicked(object sender, System.EventArgs e)
        {
            if (counter1 < (images.Length - 1))
            {
                counter1 = counter1 + 1;
            }
            else
            {
                counter1 = 0;
            }
            btn1.Source = "drawable/" + images[counter1];
        }

        private void Btn2_Clicked(object sender, System.EventArgs e)
        {
            if (counter2 < (images.Length - 1))
            {
                counter2 = counter2 + 1;
            }
            else
            {
                counter2 = 0;
            }
            btn2.Source = "drawable/" + images[counter2];
        }

        private void Btn3_Clicked(object sender, System.EventArgs e)
        {
            if (counter3 < (images.Length - 1))
            {
                counter3 = counter3 + 1;
            }
            else
            {
                counter3 = 0;
            }
            btn3.Source = "drawable/" + images[counter3];
        }

        private void Btn4_Clicked(object sender, System.EventArgs e)
        {
            if (counter4 < (images.Length - 1))
            {
                counter4 = counter4 + 1;
            }
            else
            {
                counter4 = 0;
            }
            btn4.Source = "drawable/" + images[counter4];
        }

        async void BtnEnter_Clicked(object sender, EventArgs e)
        {

            if (allCorrect == true)
            {
                await DisplayAlert("Completed", "Correct sentence found", "OK");
            }
            else
            {
                await DisplayAlert("Incorrect", "Keep searching, this is not the correct sentence", "OK");
            }
        }
    }
}
