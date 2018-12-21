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
    [RoutePrefix("Store")]
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
        [Route("AddStore")]
        public int AddStore(Store store)
        {
            var result = Store.AddStore(store);
            return result;
        }

        /// <summary>
        /// 查看店铺信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
       [Route("GetStores")]

        public List<Store> GetStores()
        {
            var result = Store.GetStores();
            return result;
        }

        /// <summary>
        ///查询单个店铺 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStore")]
        public List<Store> GetStore(int id)
        {
            var result = Store.GetStore(id);
            return result;
        }


        /// <summary>
        ///查询单个店铺 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStoreByName")]
        public List<Store> GetStoreByName(string Name)
        {
            var result = Store.GetStores().Where(n=>n.StoreName.Contains(Name)).ToList();
            return result;
        }


        /// <summary>
        /// 销量显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStoresSales")]
        public List<Store> GetStoresSales()
        {
            var result = Store.GetStoresSales();
            return result;
        }


        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UptdateStore")]
        public int UptdateStore(Store store)
        {
            var result = Store.UptdateStore(store);
            return result;
        }

        /// <summary>
        /// 修改店铺通过状态
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UptdateBoStoreState")]
        public int UptdateBoStoreState(int ID, int state)
        {
            var result = Store.UptdateBoStoreState(ID,state);
            return result;
        }

        /// <summary>
        /// 修改店铺驳回状态
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UptdateToStoreState")]
        public int UptdateToStoreState(int ID, int state)
        {
            var result = Store.UptdateToStoreState(ID, state);
            return result;
        }

        /// <summary>
        /// 查看所有商铺
        /// </summary>
        /// <returns></returns>
        [Route("ShowStores")]
        [HttpGet]
        public List<Store> ShowStores(int Auditing)
        {
            var result = Store.ShowStores(Auditing);
            return result;
        }
    }
}

