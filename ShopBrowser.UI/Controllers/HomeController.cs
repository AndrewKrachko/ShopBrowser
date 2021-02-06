using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopBrowser.Kernel;
using ShopBrowser.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShopBrowser.UI.Controllers
{
    public class HomeController : Controller
    {
        IBrowserKernel _browserKernel;

        public HomeController(IBrowserKernel browserKernel)
        {
            _browserKernel = browserKernel;
        }

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult Shops()
        {
            return Json(_browserKernel.GetShops());
        }

        public PartialViewResult Appointment(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                _browserKernel.GetShop(int.Parse(id), out var shop);
                return PartialView(shop);
            }

            return PartialView(new Shop() { Id=-1, CloseTime = DateTime.Now, OpenTime=DateTime.Now, Description="", ShopName=""});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
