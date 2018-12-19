using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;
using Unity.Attributes;
using SunFlower.IServices;

namespace SunFlower.Api.Controllers
{
    [RoutePrefix("Collect")]
    /// <summary>
    /// 收藏控制器
    /// </summary>
    public class CollectController : ApiController
    {
        [Dependency]
        public ICollect Collect { get; set; }

        /// <summary>
        /// 显示收藏
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCollects")]
        public List<Collect> GetCollects()
        {
            var CollectList = Collect.GetCollects();
            return CollectList;
        }

        /// <summary>
        /// 显示单个收藏
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCollectByID")]
        public List<Collect> GetCollectByID(string storenumber)
        {
            var CollectList = Collect.GetCollectByID(storenumber);
            return CollectList;
        }

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCollect")]
        public int AddCollect(Collect collect)
        {
            var result = Collect.AddCollect(collect);
            return result;
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteCollect")]
        public int DeleteCollect(int id)
        {
            var result = Collect.DeleteCollect(id);
            return result;
        }
    }
}
