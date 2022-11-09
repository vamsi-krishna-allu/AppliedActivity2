using AppliedActivity2.Models;
using Microsoft.Maui.ApplicationModel.Communication;

namespace AppliedActivity2.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        HolidayListView.ItemSelected += async (sender, e) =>
        {
            Holidays holidays = (Holidays)e.SelectedItem;
            List<Province> provinces = holidays.Provinces;
            await Navigation.PushAsync(new HolidayDetailsPage
            {
                BindingContext = provinces
            });
            
        };
    }
}

