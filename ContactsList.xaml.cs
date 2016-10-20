using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace a15
{
	public partial class ContactsList : ContentPage
	{
		List<Contact> contacts = null;
		IContactOperator contOperator = null;

		void Save_Clicked (object sender, System.EventArgs e)
		{
			contOperator.Clear ();
			if (contacts != null) {
				foreach (var cont in contacts) {
					if (cont.isSelected)
						contOperator.AddPhone (cont.phone);
				}
			}
		}

		public ContactsList ()
		{
			InitializeComponent ();
		}

		public void Load (IContactOperator op)
		{
			contOperator = op;
			contacts = contOperator.GetFromMobile ();

			TableView tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot
				{
				}
			};

			for (int i = 0; i < contacts.Count; ++i ) {
				var cont = contacts [i];

				if (cont.phone == "" || cont.phone == null)
					continue;
				
				SwitchCell cntSwt = new SwitchCell ();
				tableView.Root.Add (new TableSection { cntSwt });
				cntSwt.Text = cont.name;
				//cntSwt.On = cont.isSelected;

				cntSwt.OnChanged += (sender, e) => { 
					cont.isSelected = cntSwt.On; 
				};
			}

			ContactsLayout.Children.Add (tableView);

		}

		public void AddContactRecord (string name, string phone)
		{
			
		}
	}
}
