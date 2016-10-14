using Xamarin.Forms;
using System;
using System.Text;
using System.Net;


namespace a15
{
	public partial class a15Page : ContentPage
	{
		void Handle_Clicked (object sender, System.EventArgs e)
		{
			SendSms.Send ("+79265033180", "Я нахожусь здесь: " + LocationLogic.Get ());
		}

		public a15Page ()
		{
			InitializeComponent ();

			LocationLogic.Init ();

			string vue = LocationLogic.Get ();

			geoText.Text = vue;
		}



	}
}
