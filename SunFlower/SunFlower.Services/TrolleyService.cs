using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.IServices;
using SunFlower.MODEL;
using Oracle.DataAccess.Client;
using Dapper;

namespace SunFlower.Services
{

    /// <summary>
    ///购物车实现 
    /// </summary>
    public class TrolleyService : ITrolley
    {
        
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        public int AddTrolley(Trolley trolley)
        {
            using (OracleConnection conn = DapperHelper.GetConnString()) {

                conn.Open();
                string sql = @"insert into trolley(trolleynumber,userid,storenumber,foodnumber,createtime,money,userphone,addressid) values(:trolleynumber,:userid,:storenumber,:foodnumber,:createtime,:money,:userphone,:addressid)";
                int result = conn.Execute(sql, trolley);
                return result;
            }
        }

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteTrolley(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

                conn.Open();
                string sql = @"delete from  trolley where id=:id)";
                int result = conn.Execute(sql, new { id=ID});
                return result;
            }
        }

        /// <summary>
        /// 获取购物车
        /// </summary>
        /// <returns></returns>
        public List<Trolley> GetTrolleys()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

              
                string sql = @"select a.trolleynumber,b.username,c.storename,a.money,a.userphone,d.address from trolley a join users b on a.userid=b.id join store c on a.storenumber=c.storenumber join user_adders d on a.addressid=d.id";
                var trolleyList = conn.Query<Trolley>(sql,null);
                return trolleyList.ToList() ;
            }
        }

        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        public int UpdateTrolley(Trolley trolley)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

                conn.Open();
                string sql = @"update trolley set trolleynumber=:trolleynumber,userid=:userid,storenumber=:storenumber,foodnumber=:foodnumber,createtime=:createtime,money=:money,userphone=:userphone,addressid=:addressid where id=:id";
                int result = conn.Execute(sql, trolley);
                return result;
            }
        }
    }
}
