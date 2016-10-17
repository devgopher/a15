using System;
using System.Collections.Generic;

namespace a15
{
	public interface IContactOperator
	{
		void AddPhone (string phone);
		void AddSkype (string skype);

		void DelPhone (string phone);
		void DelSkype (string skype);

		List<string> GetPhones ();
		List<string> GetSkypes ();
	}
}
