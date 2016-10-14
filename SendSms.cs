using System;

namespace a15
{
	public static class SendSms
	{
		public delegate void SendSmsDelegate( String destinationAddress, String text );
		public static SendSmsDelegate Send;

		public static void Prepare ( SendSmsDelegate sendSmsProc )
		{
			Send = sendSmsProc;
		}
	}
}
