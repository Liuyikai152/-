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
        public int AddUsers(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString()) {

                conn.Open();
         
                string sql =@"insert into users(useraddressid,username,turename,userphone,createtime,upttime,wallet,usertype) values(:useraddressid,:username,:turename,:userphone,:createtime,:upttime,:wallet,:usertype)";
                
                int Add = conn.Execute(sql,users);
                
                return Add;
            }
        }

        public int DeleteUsers(int ID)
        {
            throw new NotImplementedException();
        }

       
        public List<Users> GetUsers()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql =@"select * from Users";
                var UsersList = conn.Query<Users>(sql, null);
                return UsersList.ToList<Users>();
            }
        }

        public int UptdateUsers(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
