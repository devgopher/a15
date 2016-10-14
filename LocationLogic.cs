using System;
using Xamarin.Forms;

namespace a15
{
	public static class LocationLogic
	{
		public delegate void InitLocation ();
		public delegate string GetLocation ();

		private static InitLocation initLoc;
		private static  GetLocation getLoc;

		public static void Prepare (InitLocation _initLoc, GetLocation _getLoc)
		{
			initLoc = _initLoc;
			getLoc = _getLoc;
		}

		public static void Init ()
		{
			initLoc ();
		}

		public static string Get ()
		{
			return getLoc ();
		}
	}
}
