using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace a15
{
	public partial class ContactsList : ContentPage
	{
		List<Contact> contacts = null;
		IContactOperator contOperator = null;

		void Handle_TextChanged (object sender, TextChangedEventArgs e)
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

		void Save_Clicked (object sender, System.EventArgs e)
		{
			contOperator.Clear ();
			if (contacts != null) {
				foreach (var cont in contacts) {
					if (cont.isSelected)
						contOperator.AddPhone (cont.phone);
				}
			}

			//this.
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

			List<Contact> markedContacts = new List<Contact> ();

			var usedPhones = contOperator.GetPhones ();
			var usedSkypes = contOperator.GetSkypes ();

			tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot
				{
				}
			};

			contCells.Clear ();

			// в первую очередь высвечиваем ранее выбранные контакты
			for (int i = 0; i < contacts.Count(); ++i) {
				var cont = contacts [i];

				if (cont.phone == "" || cont.phone == null)
					continue;


				if (usedPhones.Any ((x) => { return x == cont.phone; }) ||
				    usedSkypes.Any ((x) => { return x == cont.skype; }) ) {
					SwitchCell cntSwt = new SwitchCell ();
					TableSection newTS = new TableSection { cntSwt };

					tableView.Root.Add (newTS);
					cntSwt.Text = cont.name;
					cntSwt.On = true;

					cont.isSelected = true;

					cntSwt.OnChanged += (sender, e) => {
						cont.isSelected = cntSwt.On;
					};

					contCells [newTS] = cntSwt;
					markedContacts.Add ( contacts[i] );
				}
			}

			// Далее выводим все прочие контакты
			for (int i = 0; i < contacts.Count(); ++i ) {
				if (contacts [i] == null)
					continue;
				var cont = contacts [i];

				if (cont.phone == "" || cont.phone == null)
					continue;

				// Если контакт уже был выбран ранее - не показываем его
				if (markedContacts.Any ((x) => (x == cont)))
					continue;
				
				SwitchCell cntSwt = new SwitchCell ();
				TableSection newTS = new TableSection { cntSwt };

				tableView.Root.Add (newTS);
				cntSwt.Text = cont.name;
				cntSwt.On = false;

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
