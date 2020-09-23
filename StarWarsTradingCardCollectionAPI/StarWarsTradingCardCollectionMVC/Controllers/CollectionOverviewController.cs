using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarWarsTradingCardCollectionMVC.ViewModels;

namespace StarWarsTradingCardCollectionMVC.Controllers
{
    public class CollectionOverviewController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string url = "https://localhost:5001/api/CollectionOverview";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<List<SetIndexVM>>(data);
                }
            }

            return View();
        }
    }
}
