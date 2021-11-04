using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ingredient_alternatives.Models
{
    public class AuthResult 
    {
        public string access_token {get; set;}
        public string token_type {get; set;}
        public int expires_in {get; set;}
    }
}