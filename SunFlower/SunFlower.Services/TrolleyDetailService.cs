using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.IServices;
using SunFlower.MODEL;
using Dapper;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;

namespace SunFlower.Services
{
    public class TrolleyDetailService : ITrolleyDetails
    {

        

        /// <summary>
        /// 添加购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int AddTrolleyDetails(TrolleyDetails trolleyDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"";
                int result = conn.Execute(sql, trolleyDetails);
            
                return result;
            }
        }

        /// <summary>
        /// 删除购物车详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int deleteTrolleyDetails(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"";
                int result = conn.Execute(sql, new { id=ID}); 
                return result;
            }
        }

        /// <summary>
        /// 查看购物车详情
        /// </summary>
        /// <returns></returns>
        public List<TrolleyDetails> GetTrolleyDetails()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"";
                var trolleyDetailsList = conn.Query<TrolleyDetails>(sql,null);
                if (trolleyDetailsList != null)
                {
                    return trolleyDetailsList.ToList();
                }
                return null;
            }
        }

        /// <summary>
        /// 修改购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int UptdateTrolleyDetails(TrolleyDetails trolleyDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"";
                int result = conn.Execute(sql, trolleyDetails);
                return result;
            }
        }
    }
}
