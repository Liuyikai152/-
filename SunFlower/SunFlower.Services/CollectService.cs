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
                string sql = string.Format("select store.id,store.StoreImg,store.conntent from Collect join Store on(collect.storenumber=store.storenumber)");
                var collectList = conn.Query<Collect>(sql, null);
                return collectList.ToList<Collect>();
            }
        }

        
    }
}
