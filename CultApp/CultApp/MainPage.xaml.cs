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
        public string[] images = {"real2.png", "fake1.png", "fake2.png", "fake3.png", "real1.png", "fake4.png", "fake5.png", "real3.png", "fake6.png", "fake7.png", "fake8.png", "real4.png" };
        public int counter1 = 0;    //array counter for button 1
        public int counter2 = 3;    //array counter for button 2
        public int counter3 = 2;    //array counter for button 3
        public int counter4 = 1;    //array counter for button 4
        public bool allCorrect = false;     //boolean to be set to true once all the correct phrases have been inputted. Ensures the second screen is kept available if players return to screen 1

        private void Btn1_Clicked(object sender, System.EventArgs e)
        {
            if (counter1 < (images.Length - 1))         //checks if the counter has reached the end of the array. If it hasn't, the counter is incremented. If it has, the counter returns to 0
            {
                counter1 = counter1 + 1;
            }
            else
            {
                counter1 = 0;
            }
            btn1.Source = "drawable/" + images[counter1];   //sets the button's image to the image in the place in the array of the value of the counter
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

            if ((counter1 == 4) && (counter2 == 0) && (counter3 == 7) && (counter4 == 11))      //checks the values of the counters to see if the correct phrases have been input. If they have, the allCorrect boolean becomes true
            {
                allCorrect = true;
            }

            if (allCorrect == true)             //if allCorrect is set to true, the second screen is displayed. Otherwise a message is displayed to encourage the players to keep trying
            {
                await Navigation.PushAsync(new Secret());
            }
            else
            {
                await DisplayAlert("Incorrect", "Keep searching, this is not the correct sentence", "OK");
            }
        }
    }
}
