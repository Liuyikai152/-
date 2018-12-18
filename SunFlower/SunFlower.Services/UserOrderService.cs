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
    /// 订单实现
    /// </summary>
    public  class  UserOrderService: IUserOrder
    {
    
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        public int AddOrder(UserOrder userOrder)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();

                string sql = @"insert into userorder(trolleyid,foodnumber,storenumber,userid,ordermoney,addersid,userphone,createtime,num,orderstate,ordernumber) values(:trolleyid,:foodnumber,:storenumber,:userid,:ordermoney,:addersid,:userphone,:createtime,:num,:orderstate,:ordernumber)";

                var result = conn.Execute(sql, userOrder);
                return result;
            }
        }

        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
       public  List<UserOrder> GetUserOrders()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();

                string sql = @"select * from users  left join  userorder  on (users.id=userorder.userid)";

                var userOrdersList = conn.Query<UserOrder>(sql, null);
                if (userOrdersList != null)
                {
                    return userOrdersList.ToList<UserOrder>();
                }
                return null;
            }
        }

       /// <summary>
       /// 获取所有订单详情并添加订单
       /// </summary>
       /// <param name="OrderNumber"></param>
       /// <returns></returns>
        public int GetUserOrdersAdd(string OrderNumber)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select Count(orderNumber) as  Num,Sum(OrderMoney) as OrderMoney,OrderNumber,CreateTime,addersid from userorder  group by orderNumber,createtime,addersid having orderNumber=:OrderNumber";
                var userOrdersList = conn.Query<UserOrder>(sql, new { OrderNumber = OrderNumber }).FirstOrDefault();

                if (userOrdersList != null)
                {
                    string sql2 = "insert into orders (money,createtime,ordernumber,num,addressid) values(:money,:createtime,:ordernumber,:num,:addressid)";
                    var result = conn.Execute(sql2, new { money = userOrdersList.OrderMoney, createtime = userOrdersList.CreateTime, ordernumber = userOrdersList.OrderNumber, num = userOrdersList.Num, addressid = userOrdersList.AddersID });
                    return result;
                }
               
                    return 0;
                
               
            }
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        public int DeleteOrder(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();

                string sql = @"delete from userorder where id=:id";

                var result = conn.Execute(sql,new { id=id});
                return result;
            }
        }

       
    }
}
