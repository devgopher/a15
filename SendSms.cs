using System;

namespace a15
{
	/// <summary>
	/// A class for sending sms
	/// </summary>
	public static class SendSms
	{
		public delegate void SendSmsDelegate( String destinationAddress, String text );
		public static SendSmsDelegate Send;

		/// <summary>
		/// Prepares SendSms for functioning
		/// </summary>
		/// <param name="sendSmsProc">Send sms proc.</param>
		public static void Prepare ( SendSmsDelegate sendSmsProc )
		{
			Send = sendSmsProc;
		}
	}
}
