using AppliedActivity2.Services;

namespace AppliedActivity2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        DependencyService.Register<HolidaysDataService>();
        DependencyService.Register<WebClientService>();

        MainPage = new AppShell();
	}
}
