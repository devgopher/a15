using System;

namespace a15
{
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
