using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.IServices;
using SunFlower.MODEL;
using Oracle.DataAccess.Client;
using Dapper;
using SunFlower.Common;

namespace SunFlower.Services
{
    /// <summary>
    /// 日志实现类
    /// </summary>
    public class StoreLogsService : IStoreLogs
    {
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="storeLogs"></param>
        /// <returns></returns>
        public int AddStoreLogs(StoreLogs storeLogs)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into StoreLogs(Userid,Storeid,Createtime) values(:Userid,:Storeid,:Createtime)";
                int result = conn.Execute(sql, storeLogs);
                return result;
            }
        }

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <returns></returns>
        public List<StoreLogs> GetStoreLogs()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from  UserLogs";
                var storeLogsList = conn.Query<StoreLogs>(sql, null);
                return storeLogsList.ToList();
            }
        }
    }
}
