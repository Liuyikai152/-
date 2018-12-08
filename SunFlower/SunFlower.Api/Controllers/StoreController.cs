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
    public class StoreController : ApiController
    {
        [Dependency]
        public IStore Store { get; set; }
        [HttpPost]
        /// <summary>
        /// 申请店铺
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int AddStore(Store store)
        {
            var result = Store.AddStore(store);
            return result;
        }
        [HttpGet]
        /// <summary>
        /// 查看店铺信息
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStores()
        {
            var result = Store.GetStores();
            return result;
        }

        [HttpPut]
        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int UptdateStore(Store store)
        {
            var result = Store.UptdateStore(store);
            return result;
        }
    }
}

