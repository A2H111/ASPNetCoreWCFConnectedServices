using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleServiceReference;
using System.Threading;

namespace WCFClientWebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //Creating Client object of Service Reference
            SimpleServiceReference.SimpleServiceClient client = new SimpleServiceReference.SimpleServiceClient();
            //Call the method from WCF Service
            string result = await client.GetDataAsync(1);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
