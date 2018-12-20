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
    public class PermissionService : IPermission
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int AddPermission(Permission  permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into T_permission(Name,Discription,url,IsUser) values (:name,:Discription,:url,:Isuser)";
                int result= conn.Execute(sql, permission);
                return result;
            }
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePermission(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from T_Permission where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Permission> GetByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from T_Permission where id=:id";
                var result = conn.Query<Permission>(sql, new { ID = id });
                return result.ToList();
            }
        }

        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        public List<Permission> GetPermissions()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select * from  T_Permission";
                var t_PermissionList = conn.Query<Permission>(sql, null);
                return t_PermissionList.ToList<Permission>();
            }
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int UpdatePermission(Permission permission)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update T_permission set name=:name,Discription=:Discription,url=:url,Isuser=:Isuser where id=:ID  ";
                int result = conn.Execute(sql, permission);
                return result;
            }
        }
    }
}
