using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace a15
{
	public partial class ContactsList : ContentPage
	{
		public ContactsList ()
		{
			InitializeComponent ();
		}

		public void Load (IContactOperator op)
		{
			var contacts = op.GetFromMobile ();


		}

		public void AddContactRecord (string name, string phone)
		{
			
		}
	}
}
