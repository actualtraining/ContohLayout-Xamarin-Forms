using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleHello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnSubmit.Clicked += BtnSubmit_Clicked;
        }

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", string.Format("Nama anda {0} {1}",
               txtFirstName.Text, txtLastName.Text), "OK");
        }

        
    }
}
