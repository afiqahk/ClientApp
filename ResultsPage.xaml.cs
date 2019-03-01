using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Views;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultsPage : ContentPage
	{
		public ResultsPage ()
		{
			InitializeComponent ();
		}

        async void Save_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewDataPage()));
        }

        public void leftPressed(object sender, EventArgs e)
        { }

        public void leftReleased(object sender, EventArgs e)
        { }

        public void rightPressed(object sender, EventArgs e)
        { }

        public void rightReleased(object sender, EventArgs e)
        { }
    }
}