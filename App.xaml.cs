using Xamarin.Forms;

namespace a15
{
	public partial class App : Application
	{
	//	public NavigationPage navi = null;
		public App ()
		{
			InitializeComponent ();
			MainPage = new NavigationPage (new a15Page ());
	//		navi = new NavigationPage (MainPage);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
