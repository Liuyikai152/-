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
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddRole(MODEL.Role  role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql1 = @"select * from T_Role where Name=:Name";
                 var Roles = conn.Query<MODEL.Role>(sql1, role);
                int result = -1;
                if (Roles.Count()==0)
                {
                    //添加角色
                    string sql = @"insert into T_role(Name,Description,Pid) values (:Name,:Description,:Pid)";
                    int result2 = conn.Execute(sql, role);

                    //获取角色id
                    string sql2 = ("select id from T_Role where Name=:Name");
                    var id = conn.Query<int>(sql2, role).FirstOrDefault();

                    var roles = role.Pid.Split(',');

                    for (int i = 0; i <roles.Length; i++)
                    {
                        MODEL.RolePermission rolePermission = new RolePermission();
                        rolePermission.Role_Id = id;
                        rolePermission.Permission_Id = Convert.ToInt32(roles[i]);
                        string sql3 = @"insert into Role_Permission (Role_Id,Permission_Id) values (:Role_Id,:Permission_Id) ";
                        result = conn.Execute(sql3, rolePermission);
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取角色id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Role> GetByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select rp.PERMISSION_id,r.Id,r.Name,r.description,r.pid from
 t_role r,ROLE_PERMISSION rp where r.id=rp.role_id and r.id=:id ";
               var result = conn.Query<Role>(sql,new { id = id });
                return result.ToList();
            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<MODEL.Role> GetRoles()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"  select WMSYS.WM_CONCAT(p.name) as Permission, r.name,r.description,r.id 
  from 
  T_Permission p, role_permission rp ,T_Role r where  p.id=rp.permission_id AND rp.role_id=r.id 
   group by r.id,r.name,r.description";
                var t_RoleList = conn.Query<MODEL.Role>(sql, null);
                return t_RoleList.ToList<MODEL.Role>();
            }
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int UpdateRole(MODEL.Role role)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql1 = @"select * from T_Role where Name=:Name";
                var Roles = conn.Query<MODEL.Role>(sql1, role);
                int result =-1;
                if (Roles.Count() == 1)
                {
                    //修改角色
                    string sql = @"update T_role set Name=:Name,Description=:Description where id=:id";
                    int result2 = conn.Execute(sql, role);

                    string sql2 = ("delete from role_permission where role_id=:role_id");
                    conn.Execute(sql2, new { role_id = role.ID });

                    var roles = role.Pid.Split(',');

                    for (int i = 0; i < roles.Length; i++)
                    {
                        MODEL.RolePermission rolePermission = new RolePermission();
                        rolePermission.Role_Id = role.ID;
                        rolePermission.Permission_Id = Convert.ToInt32(roles[i]);
                        string sql3 = @"insert into Role_Permission (role_id,Permission_Id) values (:role_id,:Permission_Id)";
                        result = conn.Execute(sql3, rolePermission);
                    }
                }
                return result;
            }
        }


    }
}
