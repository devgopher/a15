using System;
using System.Collections.Generic;

namespace a15
{
	public struct Contact
	{
		public string name;
		public string phone;
		public string skype;
	}

	public interface IContactOperator
	{
		List<Contact> GetFromMobile ();

		void AddPhone (string phone);
		void AddSkype (string skype);

		void DelPhone (string phone);
		void DelSkype (string skype);

		List<string> GetPhones ();
		List<string> GetSkypes ();
	}
}
