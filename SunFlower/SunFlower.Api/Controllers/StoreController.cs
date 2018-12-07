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
    public class StoreController : ApiController
    {
        StoreService storeService = new StoreService();
        [HttpPost]
        /// <summary>
        /// 申请店铺
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int AddStore(Store store)
        {
            var addStore = storeService.AddStore(store);
            return addStore;
        }
        [HttpGet]
        /// <summary>
        /// 查看店铺信息
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStores()
        {
            var storeList = storeService.GetStores();
            return storeList;
        }

        [HttpPut]
        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int UptdateStore(Store store)
        {
            var uptdateStore = storeService.UptdateStore(store);
            return uptdateStore;
        }
    }
}

