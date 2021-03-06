﻿using System;
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

    [RoutePrefix("Order")]
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


        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateOrders")]
        public int UpdateOrders(string orderNumber, string orderState)
        {
            var result = Orders.UpdateOrders(orderNumber, orderState);
            return result;
        }


        [HttpGet]
        [Route("GetOrders")]
        public List<Orders> GetOrders()
        {
            var OrderList = Orders.GetOrders();
            return OrderList;
        }
        /// <summary>
        /// 显示单个订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrder")]
        public List<Orders> GetOrder(int id)
        {
            var OrdersList = Orders.GetOrder(id);
            return OrdersList;
        }


        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteOrder")]
        public int DeleteOrder(int id)
        {
            var result = Orders.DeleteOrder(id);
            return result;
        }
    }
}
