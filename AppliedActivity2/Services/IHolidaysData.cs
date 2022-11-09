using AppliedActivity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity2.Services
{
    interface IHolidaysData<T>
    {
        Task<IEnumerable<Holidays>> GetHolidaysAsync();
    }
}
