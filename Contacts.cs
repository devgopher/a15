using System;
using System.IO;
using System.Collections.Generic;


namespace a15
{
	/// <summary>
	/// A class for managing your trustworthy contacts
	/// </summary>
	public static class Contacts
	{
		static List<string> phoneNumbers = new List<string> ();
		static List<string> skypeIds = new List<string> ();
		static IContactOperator contOperator;

		public static void SetOperator ( IContactOperator ico )
		{
			contOperator = ico;
		}

		/// <summary>
		/// Gets contact operator for a current platform
		/// </summary>
		/// <returns>The operator.</returns>
		public static IContactOperator GetOperator ()
		{
			return contOperator;
		}

		/// <summary>
		/// Adds a phone contact
		/// </summary>
		/// <param name="phoneNum">Phone number</param>
		public static void AddPhone (string phoneNum)
		{
			contOperator.AddPhone (phoneNum);
		}

		/// <summary>
		/// Adds a skype login
		/// </summary>
		/// <param name="skype">Skype</param>
		public static void AddSkype( string skype )
		{
			contOperator.AddSkype( skype );
		}

		/// <summary>
		/// Deletess a phone.
		/// </summary>
		/// <param name="phoneNum">Phone number</param>
		public static void DelPhone (string phoneNum)
		{
			contOperator.DelPhone (phoneNum);
		}


		/// <summary>
		/// Deletes a skype login
		/// </summary>
		/// <param name="skype">Skype.</param>
		public static void DelSkype (string skype)
		{
			contOperator.DelSkype (skype);
		}

		/// <summary>
		/// Gets phones list from internal memory 
		/// </summary>
		/// <returns>phones</returns>
		public static List<string> GetPhones ()
		{
			return contOperator.GetPhones ();
		}

		/// <summary>
		/// Gets skype logins list from internal memory 
		/// </summary>
		/// <returns>skype logins</returns>
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
