using Dapper;
using Oracle.DataAccess.Client;
using SunFlower.Common;
using SunFlower.IServices;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.Services
{
    public class TUsersService : ITUsers
    {
        public int AddUsers(TUsers  users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into T_Users(UserName,PassWord,RoleID) values (:UserName,:PassWord,:RoleID) ";
                int result = conn.Execute(sql, users);
                return result;
            }
        }

        public int DeleteUsers(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from T_Users where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        public List<TUsers> GetUsers()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from T_Users";
                var t_UsersList = conn.Query<TUsers>(sql, null);
                return t_UsersList.ToList<TUsers>();
            }
        }

        public int Login(string userName, string passWord)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from T_Users where UserName=:userName and PassWord=:passWord";
                var list = conn.Query<TUsers>(sql,new { userName = userName , passWord = passWord }).ToList();
                if (list.Count() > 0)
                    return 1;
                return 0;
            }
        }

        public int UpdateUsers(TUsers  users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update  T_Users set UserName=:UserName,PassWord=:PassWord,RoleID=:RoleID where id=ID";
                int result = conn.Execute(sql, users);
                return result;
            }
        }
    }
}
