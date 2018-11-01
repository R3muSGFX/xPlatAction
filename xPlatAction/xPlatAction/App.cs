using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xPlatAction
{
	public class App : Application
	{
		public App()
		{
			CreateResources();

			MainPage = new Views.MainPage();
		}

		#region Methods

		private void CreateResources()
		{
			Resources = new ResourceDictionary
			{
				{ "primaryColor", Color.FromHex("3367D6") },
				{ "primaryDarkColor", Color.FromHex("254FAE") },
			};
			var navigationStyle = new Style(typeof(NavigationPage));
			var barTextColorSetter = new Setter
			{
				Property = NavigationPage.BarTextColorProperty,
				Value = Color.White
			};
			var barBackgroundColorSetter = new Setter
			{
				Property = NavigationPage.BarBackgroundColorProperty,
				Value = Resources["primaryColor"]
			};

			navigationStyle.Setters.Add(barTextColorSetter);
			navigationStyle.Setters.Add(barBackgroundColorSetter);

			Resources.Add(navigationStyle);
		}

		protected override void OnStart() { }

		protected override void OnSleep() { }

		protected override void OnResume() { }

		#endregion Methods

	}
}