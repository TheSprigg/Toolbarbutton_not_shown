using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    async void OnClick(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Page2());
	    }
    }
}
