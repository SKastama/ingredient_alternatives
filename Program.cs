using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using unirest_net.http;
using System.Xml;

namespace ingredient_alternatives
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            HttpResponse<string> response = Unirest.get("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/food/ingredients/substitutes?ingredientName=butter")
                .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", "82e202cbadmsh7e539dd7106113dp1f7750jsn0cdddebbb461")
                .header("Accept", "application/json")
                .asJson<string>();
            Console.WriteLine(response.Body.ToString());
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Body.ToString());
            Console.WriteLine(doc.DocumentElement.FirstChild.InnerText);
            // response = Unirest.get("https://microsoft-azure-translation-v1.p.rapidapi.com/GetLanguagesForTranslate")
            //     .header("X-RapidAPI-Host", "microsoft-azure-translation-v1.p.rapidapi.com")
            //     .header("X-RapidAPI-Key", "<YOUR_RAPID_API_KEY>")
            //     .asJson<string>();
            
            // doc.LoadXml(response.Body.ToString());
            
            // foreach(XmlNode node in doc.DocumentElement.ChildNodes){
            // Console.WriteLine(node.InnerText);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
