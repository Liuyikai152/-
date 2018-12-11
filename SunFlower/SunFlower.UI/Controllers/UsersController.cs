using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunFlower.UI.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UsersManager()
        {
            return View();
        }
    }
}