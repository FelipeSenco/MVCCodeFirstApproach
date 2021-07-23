using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Filters;

namespace EFDbFirstApproachExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        [MyActionFilter]
        [MyResultFilter]        
        public ActionResult Index()
        {
            return View();
        }
    }
}