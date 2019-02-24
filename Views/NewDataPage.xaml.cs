using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1.Models;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewDataPage : ContentPage
    {
        public Data Data { get; set; }

        public NewDataPage()
        {
            InitializeComponent();

            Data = new Data
            {
                Name = "Object name",
                Measurement = "21",
                Distance = "3"
                //CHANGE: placeholder data for Measurement and Distance; load these from ResultsPage dsiplay
            };

            BindingContext = this;
        }

        //CHANGE: save to database
        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddData", Data);
            await Navigation.PopModalAsync();
        }
    }
}