using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;

namespace SunFlower.Api.Controllers
{
    /// <summary>
    /// 轮播图控制器
    /// </summary>
    public class BootstrapController : ApiController
    {
        BootstrapServices services = new BootstrapServices();
      
        /// <summary>
        /// 获取轮播图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Bootstrap> GetBootstraps()
        {
            var bootstrapList = services.GetBootstraps();
            return bootstrapList;
        }
    }
}
