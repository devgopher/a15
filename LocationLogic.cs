using System;
using Xamarin.Forms;

namespace a15
{
	public static class LocationLogic
	{
		public delegate void InitLocation ();
		public delegate string GetLocation ();

		private static InitLocation initLoc;
		private static GetLocation getLoc;
		private static GetLocation getLocLong;
		private static GetLocation getLocLat;


		public static void Prepare (InitLocation _initLoc, GetLocation _getLoc, GetLocation _getLocLat, GetLocation _getLocLong)
		{
			initLoc = _initLoc;
			getLoc = _getLoc;
			getLocLat = _getLocLat;
			getLocLong = _getLocLong;
		}

		public static void Init ()
		{
			initLoc ();
		}

		public static string Get ()
		{
			return getLoc ();
		}

		public static string GetLong() {
			return getLocLong ();
		}

	public static string GetLat() {
			return getLocLat ();
		}
	}
}
