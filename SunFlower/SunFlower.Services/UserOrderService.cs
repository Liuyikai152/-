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

                string sql = @"insert into userorder(trolleyid,foodnumber,storenumber,userid,ordermoney,addersid,userphone,createtime,num,orderstate,storeorderstate,ordernumber) values(:trolleyid,:foodnumber,:storenumber,:userid,:ordermoney,:addersid,:userphone,:createtime,:num,:orderstate,:storeorderstate,:ordernumber)";

                var add = conn.Execute(sql, userOrder);
                return add;
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
                return userOrdersList.ToList<UserOrder>();
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

                var delete = conn.Execute(sql,new { id=id});
                return delete;
            }
        }

       
    }
}
