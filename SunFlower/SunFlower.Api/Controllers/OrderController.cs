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

    public class OrderController : ApiController
    {
        OrderService services = new OrderService();

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddOrders(Orders orders)
        {
            var result = services.AddOrders(orders);
            return result;
        }
        [HttpGet]
        public List<Orders> GetOrders()
        {
            var OrderList = services.GetOrders();
            return OrderList;
        }

    }
}
