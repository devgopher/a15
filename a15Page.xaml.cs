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
				string mapLink = String.Format (@"https://maps.google.com/maps?z=18&q=loc:{0}+{1}", LocationLogic.GetLat(), LocationLogic.GetLong());

				mapLink = mapLink.Replace (',', '.');

				SendSms.Send (phone, String.Format("I'm here: {0} maps: {1}", LocationLogic.Get(), mapLink));
				//SendWhatsApp.Send ( phone, String.Format ("Я нахожусь здесь: {0}", LocationLogic.Get ()));
			}
		}

		void GetContacts_Clicked (object sender, System.EventArgs e)
		{
			ContactsList clForm = new ContactsList ();
			clForm.Load (Contacts.GetOperator ());
			App.Current.MainPage.Navigation.PushAsync ( clForm );
		}


		public a15Page ()
		{
			InitializeComponent ();
			LocationLogic.Init ();

			geoText.Text = LocationLogic.Get ();
		}
	}
}
