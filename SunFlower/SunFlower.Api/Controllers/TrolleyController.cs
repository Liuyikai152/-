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

namespace SunFlower.Api.Controllers
{
    public class TrolleyController : ApiController
    {
        TrolleyService service = new TrolleyService();


        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddTrolley(Trolley trolley)
        {


            int add = service.AddTrolley(trolley);
                return add;
            
        }

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteTrolley(int ID)
        {

            int delete = service.DeleteTrolley(ID);
                return delete;
            
        }

        /// <summary>
        /// 获取购物车
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Trolley> GetTrolleys()
        {

            var trolleyList = service.GetTrolleys();
                return trolleyList;
            
        }

        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        [HttpPut]
        public int UpdateTrolley(Trolley trolley)
        {

            int update = service.UpdateTrolley(trolley);
            return update;
            
        }
    }
}
