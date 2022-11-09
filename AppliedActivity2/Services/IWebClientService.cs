using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity2.Services
{
    internal interface IWebClientService
    {
        Task<string> GetAsync(string uri);
    }
}
