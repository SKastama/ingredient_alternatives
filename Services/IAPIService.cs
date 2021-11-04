using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingredient_alternatives.Services
{
    public interface IAPIService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}