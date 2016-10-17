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
			var phones = Contacts.GetPhones ();
			foreach (var phone in phones) {
				SendSms.Send (phone, String.Format("Я нахожусь здесь: {0}", LocationLogic.Get()));
			}
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
