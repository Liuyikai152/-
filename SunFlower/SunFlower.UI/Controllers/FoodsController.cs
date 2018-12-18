using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunFlower.UI.Controllers
{
    public class FoodsController : Controller
    {
        // GET: Foods
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string FileImg()
        {
            HttpPostedFileBase Name = Request.Files["File"];
            return UploadFiles.UpLoadFile(Name);
        }

    }
}