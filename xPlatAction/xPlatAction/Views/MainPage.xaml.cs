using System.Linq;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xPlatAction.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void BtnClick_Clicked(object sender, System.EventArgs e)
		{
			MobileServiceClient client = new MobileServiceClient("http://192.168.35.206:5282");
			var items = await client.GetTable<TodoItem>().ReadAsync();
			var item = items.FirstOrDefault();
			lblMsg.Text = item.Text;
		}
	}

	public class TodoItem
	{
		public string Id { get; set; }

		public string Text { get; set; }

		public bool Complete { get; set; }
	}
}