using System;
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
                string sql = @"select o.id,o.ordernumber,o.money,o.num,a.address,a.username,o.createtime from Orders o join user_adders a on o.addressid=a.id";
                var ordersList = conn.Query<Orders>(sql, null);
                return ordersList.ToList<Orders>();
            }
        }


       

        /// <summary>
        /// 显示单个订单
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetOrder(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select o.id as oid,f.id as fid,s.id as sid,f.filename,f.foodname,u.num,f.foodsprice,s.storename from Orders o right join userorder u on o.ordernumber=u.ordernumber join food f on u.foodnumber=f.foodnumber join store s on f.storenumber=s.storenumber  where o.id=:id";
                var ordersList = conn.Query<Orders>(sql, new { id = id });
                return ordersList.ToList<Orders>();
            }
        }
    }
}
