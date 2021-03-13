using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
namespace Tools.Areas.Chat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Chat/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}