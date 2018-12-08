﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.MODEL;
using SunFlower.IServices;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;

namespace SunFlower.Services
{
    /// <summary>
    /// 订单实现接口
    /// </summary>
    public class OrderService : IOrders
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public int AddOrders(Orders orders)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Food (money, addressid, createtime, ordernumber, prices, num, foodnumber,storenumber) 
                     values(:money, :addressid, :createtime, :ordernumber, :prices, :num, :foodnumber,:storeNumber)";
                int result = conn.Execute(sql, orders);
                return result;
            }
        }

        /// <summary>
        /// 显示订单
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetOrders()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select o.ordernumber,s.storename,f.foodname,o.money,u.Address,o.num,o.prices,o.createtime from orders o join store s on o.storenumber=s.storenumber join food f on o.foodnumber=f.foodnumber join User_Adders u on o.addressid=u.id";
                var ordersList = conn.Query<Orders>(sql, null);
                return ordersList.ToList<Orders>();
            }
        }
    }
}