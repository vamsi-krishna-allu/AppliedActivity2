using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity2.Models
{
    internal class Holidays
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public int Federal { get; set; }

        public string ObservedDate { get; set; }

        public List<Province> Provinces { get; set; }

        public Holidays(int id, string date, string nameEn, string nameFr, int federal, string observedDate, List<Province> provinces)
        {
            Id = id;
            Date = date;
            NameEn = nameEn;
            NameFr = nameFr;
            Federal = federal;
            ObservedDate = observedDate;
            Provinces = provinces;
        }
    }
}
