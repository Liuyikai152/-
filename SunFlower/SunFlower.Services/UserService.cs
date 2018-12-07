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
    /// 用户实现表
    /// </summary>
    public class UserService : IUsers
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString()) {

                conn.Open();
         
                string sql =@"insert into users(useraddressid,username,turename,userphone,createtime,upttime,wallet,usertype) values(:useraddressid,:username,:turename,:userphone,:createtime,:upttime,:wallet,:usertype)";
                
                int Add = conn.Execute(sql,users);
                
                return Add;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteUsers(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

                conn.Open();

                string sql = @"delete from users where id=:id";

                int delete = conn.Execute(sql,new { id=id });

                return delete;
            }
        }

       /// <summary>
       /// 获取所有用户
       /// </summary>
       /// <returns></returns>
        public List<Users> GetUsers()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql =@"select * from Users";
                var UsersList = conn.Query<Users>(sql, null);
                return UsersList.ToList<Users>();
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int UptdateUsers(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

                conn.Open();

                string sql = @"update users set useraddressid=:useraddressid,username=:username,turename:turename,userphone:userphone,createtime:createtime,upttime:upttime,wallet:wallet,usertype:usertype where id=:id";

                int uptdate = conn.Execute(sql, users);

                return uptdate;
            }
        }
    }
}
