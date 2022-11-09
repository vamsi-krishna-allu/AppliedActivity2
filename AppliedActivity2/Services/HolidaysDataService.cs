using AppliedActivity2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity2.Services
{
    internal class HolidaysDataService : IHolidaysData<Holidays>
    {
        private static string API => "https://canada-holidays.ca/api/v1/holidays?year=2022&optional=false";

        /*
         * Below method is to get quotes with the API  
         */
        public async Task<IEnumerable<Holidays>> GetHolidaysAsync()
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync(API);

            var holidays = HolidaysBuilder(json);

            return holidays;
        }


        /*
         * Below method is to iterate over the response and bind the data to the list of Quotes
         */
        private List<Holidays> HolidaysBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<dynamic>(json);


            var holidays = new List<Holidays>();

            foreach (var data in response["holidays"])
            {
                var Id = data.id.ToString();
                var Date = data.date.ToString();
                var NameEn = data.nameEn.ToString();
                var NameFr = data.nameFr.ToString();
                var Federal = data.federal.ToString();
                var ObservedDate = data.observedDate.ToString();
                var Provinces = data.provinces;

                var provinces = new List<Province>();

                foreach (var ProvData in Provinces)
                {
                    var ProvId = ProvData.id.ToString();
                    var ProvNameFr = ProvData.nameFr.ToString();
                    var ProvSourceEn = ProvData.sourceEn.ToString();
                    var ProvNameEn = ProvData.nameEn.ToString();
                    var ProvSourceLink = ProvData.sourceLink.ToString();

                    provinces.Add(new Province(ProvId, ProvNameEn, ProvNameFr, ProvSourceLink, ProvSourceEn));
                }

                holidays.Add(new Holidays(Id, Date, NameEn, NameFr, Federal, ObservedDate, provinces));

            }

            return holidays;
        }

    }
}
