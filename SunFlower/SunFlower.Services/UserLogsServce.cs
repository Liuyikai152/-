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
    public class UserLogsServce : IUserLogs
    {
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="userLogs"></param>
        /// <returns></returns>
        public int AddLogs(UserLogs userLogs)
        {
            using (OracleConnection conn = DapperHelper.GetConnString()) {
                conn.Open();
                string sql = @"insert into UserLogs(Userid,Storeid,Createtime) values(:Userid,:Storeid,:Createtime)";
                int add = conn.Execute(sql, userLogs);
                return add;
            }
           
        }

        /// <summary>
        /// 查看日志
        /// </summary>
        /// <returns></returns>
        public List<UserLogs> GetUserLogs()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from  UserLogs";
                var UserLogsList = conn.Query<UserLogs>(sql, null);
                return UserLogsList.ToList();
            }
        }
    }
}
