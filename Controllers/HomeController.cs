using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Xml;
using unirest_net.http;

namespace ingredient_alternatives.Controllers
{
    public class HomeController : Controller   
    {
        // Dashboard
        [HttpGet("")]   
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}