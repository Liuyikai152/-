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

    public class OrderController : ApiController
    {
        [Dependency]
        public IOrders Orders { get; set; }

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddOrders(Orders orders)
        {
            var result = Orders.AddOrders(orders);
            return result;
        }
        [HttpGet]
        public List<Orders> GetOrders()
        {
            var OrderList = Orders.GetOrders();
            return OrderList;
        }

    }
}
