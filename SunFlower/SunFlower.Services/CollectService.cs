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
    /// 收藏实现类
    /// </summary>
    public class CollectService : ICollect
    {
        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="collect"></param>
        /// <returns></returns>
        public int AddCollect(Collect collect)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into Collect(storenumber, UserID, createtime) values(:storenumber,:UserID,:createtime)";
                int result = conn.Execute(sql,collect);
                return result;
            }
        }

        /// <summary>
        /// 显示收藏
        /// </summary>
        /// <returns></returns>
        
        public List<Collect> GetCollects()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("  select collect.id as aid,store.id,store.StoreImg,store.conntent from Collect join Store on(collect.storenumber=store.storenumber)");
                var collectList = conn.Query<Collect>(sql, null);
                return collectList.ToList<Collect>();
            }
        }

        /// <summary>
        /// 显示单个收藏
        /// </summary>
        /// <returns></returns>
        public List<Collect> GetCollectByID(string storenumber)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select storenumber from Collect where storenumber=:storenumber");
                var collectList = conn.Query<Collect>(sql, new { storenumber = storenumber });
                return collectList.ToList<Collect>();
            }
        }


        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCollect(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from Collect where id=:id";
                int result = conn.Execute(sql, new { id=id});
                return result;
            }
        }
    }
}
