using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using SunFlower.MODEL;
using SunFlower.Services;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using SunFlower.IServices;
using Unity.Attributes;
namespace SunFlower.Api.Controllers
{
    public class TrolleyController : ApiController
    {
        [Dependency]
        public ITrolley Trolley { get; set; }


        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddTrolley(Trolley trolley)
        {


            int result = Trolley.AddTrolley(trolley);
            return result;

        }

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteTrolley(int ID)
        {

            int result = Trolley.DeleteTrolley(ID);
            return result;

        }

        /// <summary>
        /// 获取购物车
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Trolley> GetTrolleys()
        {

            var result = Trolley.GetTrolleys();
            return result;

        }

        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        [HttpPut]
        public int UpdateTrolley(Trolley trolley)
        {

            int result = Trolley.UpdateTrolley(trolley);
            return result;

        }
    }
}
