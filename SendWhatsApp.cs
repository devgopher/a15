using System;

namespace a15
{
	/// <summary>
	/// A class for sending messages through WhatsApp
	/// </summary>
	public static class SendWhatsApp
	{
		public delegate void SendWhatsAppDelegate (String destinationAddress, String text);
		public static SendWhatsAppDelegate Send;

		public static void Prepare (SendWhatsAppDelegate sendWhatsAppProc)
		{
			Send = sendWhatsAppProc;
		}
	}
}
