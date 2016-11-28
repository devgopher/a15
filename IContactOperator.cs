using System;
using System.Collections.Generic;

namespace a15
{
	public class Contact
	{
		public string name;
		public string phone;
		public string skype;
		public bool isSelected;
	}

	/// <summary>
	/// An interface for ContactOperator
	/// </summary>
	public interface IContactOperator
	{
		List<Contact> GetFromMobile ();

		void AddPhone (string phone);
		void AddSkype (string skype);

		void DelPhone (string phone);
		void DelSkype (string skype);

		void Clear ();

		List<string> GetPhones ();
		List<string> GetSkypes ();
	}
}
