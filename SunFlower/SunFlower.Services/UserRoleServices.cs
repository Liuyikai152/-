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
    public class UserRoleServices : IUserRole
    {
        public int AddUserRole(UserRole user_Role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into User_Role (user_id, role_id)  values(:user_id, :role_id)";
                int result = conn.Execute(sql, user_Role);
                return result;
            }
        }

        public int DeleteUserRole(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from User_Role where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        public List<UserRole> GetUserRoles()
        {
            throw new NotImplementedException();
        }

        public int UpdateUserRole(UserRole user_Role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update  User_Role set user_id=:user_id, role_i:role_id where id=ID ";
                int result = conn.Execute(sql, user_Role);
                return result;
            }
        }

      

        List<UserRole> IUserRole.GetUserRoles()
        {
            throw new NotImplementedException();
        }
    }
}
