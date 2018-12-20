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
    public class RolePermissionServices : IRolePermission
    {
        public int AddRolePermission(RolePermission role_Permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into Role_Permission (role_id, permission_id)  values(:role_id, :permission_id)";
                int result = conn.Execute(sql, role_Permission);
                return result;
            }
        }

        public int DeleteRolePermission(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from Role_Permission where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        public List<RolePermission> GetRolePermissions()
        {
            throw new NotImplementedException();
        }

        public int UpdateRolePermission(RolePermission role_Permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update Role_Permission set role_id=:role_id,permission_id=:permission_id where id=:ID  ";
                int result = conn.Execute(sql, role_Permission);
                return result;
            }
        }
    }
}
