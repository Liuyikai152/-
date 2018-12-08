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
    public class UserOrderController : ApiController
    {

        [Dependency]
        public IUserOrder UserOrder { get; set; }

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddOrder(UserOrder userOrder)
        {

            var result = UserOrder.AddOrder(userOrder);
            return result;

        }

        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<UserOrder> GetUserOrders()
        {

            var userOrdersList = UserOrder.GetUserOrders();
            return userOrdersList;

        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteOrder(int id)
        {

            var result = UserOrder.DeleteOrder(id);
            return result;

        }
    }
}
