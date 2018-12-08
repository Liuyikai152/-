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
    /// 收藏控制器
    /// </summary>
    public class CollectController : ApiController
    {
        CollectService services = new CollectService();

        /// <summary>
        /// 显示收藏
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Collect> GetCollects()
        {
            var CollectList = services.GetCollects();
            return CollectList;
        }

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int AddCollect(Collect collect)
        {
            var result = services.AddCollect(collect);
            return result;
        }
    }
}
