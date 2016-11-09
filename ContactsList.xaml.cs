using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace a15
{
	public partial class ContactsList : ContentPage
	{
		void Handle_TextChanged (object sender, Xamarin.Forms.TextChangedEventArgs e)
		{

			foreach (var cell in contCells) {
				string input = cell.Value.Text.ToLower ();

				if (!input.Contains (e.NewTextValue.ToLower ())) {
					if (tableView.Root.Contains (cell.Key))
						tableView.Root.Remove (cell.Key);

				} else {
					if (!tableView.Root.Contains (cell.Key))
						tableView.Root.Add (cell.Key);					
				}
			}
		}

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

		private TableView tableView;

		public void Load (IContactOperator op)
		{
			contOperator = op;
			contacts = contOperator.GetFromMobile ();

			tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot
				{
				}
			};

			contCells.Clear ();

			for (int i = 0; i < contacts.Count; ++i ) {
				var cont = contacts [i];

				if (cont.phone == "" || cont.phone == null)
					continue;
				
				SwitchCell cntSwt = new SwitchCell ();
				TableSection newTS = new TableSection { cntSwt };

				tableView.Root.Add (newTS);
				cntSwt.Text = cont.name;
				//cntSwt.On = cont.isSelected;

				cntSwt.OnChanged += (sender, e) => { 
					cont.isSelected = cntSwt.On; 
				};

				contCells[newTS] = cntSwt;
			}

			ContactsLayout.Children.Add (tableView);

		}

		private Dictionary<TableSection, SwitchCell> contCells = new Dictionary<TableSection, SwitchCell> ();

		public void AddContactRecord (string name, string phone)
		{
			
		}
	}
}
