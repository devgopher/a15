using System;
using System.IO;
using System.Collections.Generic;


namespace a15
{
	public static class Contacts
	{
		static List<string> phoneNumbers = new List<string> ();
		static List<string> skypeIds = new List<string> ();
		static IContactOperator contOperator;


		static Contacts ()
		{

		}

		public static void SetOperator ( IContactOperator ico )
		{
			contOperator = ico;
		}

		public static IContactOperator GetOperator ()
		{
			return contOperator;
		}


		public static void AddPhone (string phoneNum)
		{
			contOperator.AddPhone (phoneNum);
		}

		public static void AddSkype( string skype )
		{
			contOperator.AddSkype( skype );
		}

		public static void DelPhone (string phoneNum)
		{
			contOperator.DelPhone (phoneNum);
		}

		public static void DelSkype (string skype)
		{
			contOperator.DelSkype (skype);
		}

		public static List<string> GetPhones ()
		{
			return contOperator.GetPhones ();
		}

		public static List<string> GetSkypes ()
		{
			return contOperator.GetSkypes ();
		}

		public static List<Contact> GetFromMobile ()
		{
			return contOperator.GetFromMobile ();
		}
	}
}
