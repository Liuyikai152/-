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
    public class RoleService : IRole
    {
        public int AddRole(MODEL.Role  role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into T_role(name,description,Permission) values (:Name,:description,:Permission)";
                int result = conn.Execute(sql, role);
                return result;
            }
        }
        public int DeleteRole(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from T_Role where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        public List<Role> GetByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from T_Role where id=:id";
               var result = conn.Query<Role>(sql,new { ID = id });
                return result.ToList();
            }
        }

        public List<MODEL.Role> GetRoles()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from T_Role";
                var t_RoleList = conn.Query<MODEL.Role>(sql, null);
                return t_RoleList.ToList<MODEL.Role>();
            }
        }

        public int UpdateRole(MODEL.Role  role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update T_Role setname=:name,Discription=:Discription,Permission=:Permission where id=ID ";
                int result = conn.Execute(sql, role);
                return result;
            }
        }


    }
}
