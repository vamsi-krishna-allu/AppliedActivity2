﻿using AppliedActivity2.Models;
using AppliedActivity2.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace AppliedActivity2.ViewModels
{
    internal class HolidaysListViewModel
    {
        public IHolidaysData<Holidays> DataStore => DependencyService.Get<IHolidaysData<Holidays>>();
        public ObservableRangeCollection<Holidays> Holidays { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public HolidaysListViewModel()
        {
            Holidays = new ObservableRangeCollection<Holidays>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        /*
         * Method to get quotes on refresh 
         */
        public async Task Refresh()
        {
            var holidays = await DataStore.GetHolidaysAsync();

            Holidays.AddRange(holidays);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}
