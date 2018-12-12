using SunFlower.Common;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunFlower.UI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        [HttpPost]
        public ContentResult UploadFileNew()
        {
            UploadFileDTO model = new UploadFileDTO();
            HttpPostedFileBase file = Request.Files["uploadfile_ant"];
            if (file != null)
            {
                //公司编号+上传日期文件主目录
                model.Catalog = DateTime.Now.ToString("yyyyMMdd");
                model.ImgIndex = Convert.ToInt32(Request.Form["imgIndex"]);

                //获取文件后缀
                string extensionName = System.IO.Path.GetExtension(file.FileName);

                //文件名
                model.FileName = System.Guid.NewGuid().ToString("N") + extensionName;

                //保存文件路径
                string filePathName = System.IO.Path.Combine(CommonHelper.GetConfigValue("ImageAbsoluteFolderTemp"), model.Catalog);
                if (!System.IO.Directory.Exists(filePathName))
                {
                    System.IO.Directory.CreateDirectory(filePathName);
                }
                //相对路径
                string relativeUrl = CommonHelper.GetConfigValue("ImageRelativeFolderTemp");
                file.SaveAs(System.IO.Path.Combine(filePathName, model.FileName));

                //获取临时文件相对完整路径
                model.Url = System.IO.Path.Combine(relativeUrl, model.Catalog, model.FileName).Replace("\\", "/");
            }
            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(model));
        }
    }
}