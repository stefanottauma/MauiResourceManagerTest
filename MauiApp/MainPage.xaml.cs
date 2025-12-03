using System.Globalization;
using MauiApp.Resources.Texts;


namespace MauiApp;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();
		
		var culture = new CultureInfo("de-DE");
		Label.Text = Translations.ResourceManager.GetString("Text", culture) ?? string.Empty;
	}

	


}