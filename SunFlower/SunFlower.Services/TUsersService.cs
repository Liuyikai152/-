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
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(TUsers users)
        {

            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql1 = @"select * from T_Users where UserName=:UserName";
                var Roles = conn.Query<TUsers>(sql1, users);
                int result = -1;
                if (Roles.Count() == 0)
                {
                    //添加用户
                    string sql = @"insert into T_Users(UserName,PassWord,RoleId) values (:UserName,:PassWord,:RoleId)";
                    int result2 = conn.Execute(sql, users);

                    //获取用户id
                    string sql2 = ("select id from T_Users where UserName=:UserName");
                    var id = conn.Query<int>(sql2, users).FirstOrDefault();

                    var user = users.RoleId.Split(',');

                    for (int i = 0; i < user.Length; i++)
                    {
                        UserRole userRole = new UserRole();
                        userRole.User_Id = id;
                        userRole.Role_Id = Convert.ToInt32(user[i]);
                        string sql3 = @"insert into User_role (Role_Id,User_Id) values (:Role_Id,:User_Id) ";
                        result = conn.Execute(sql3, userRole);
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TUsers> GetByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @" select u.Id,u.UserName,u.PassWord,ur.Role_id from t_users u,user_role ur where u.id=ur.user_id and u.id=:id ";
                var result = conn.Query<TUsers>(sql, new { id = id });
                   return result.ToList(); 
            }
        }

        /// <summary>
        /// 获取权限路径
        /// </summary>
        /// <returns></returns>

        public List<TUsers> GetPermissiomUrl(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                //               string sql = @"select WMSYS.WM_CONCAT(r.name) as rolename, p.name,p.url from t_Users u join user_role ur on u.id=ur.user_id join t_Role r on ur.role_id=r.id join
                //role_permission rp on r.id=rp.role_id join t_permission p on rp.permission_id=p.id where u.id=:id group by p.name,p.url";
                string sql = @"select r.name as rolename, p.name,p.url from t_Users u join user_role ur on u.id=ur.user_id join t_Role r on ur.role_id=r.id join role_permission rp on r.id=rp.role_id join t_permission p on rp.permission_id=p.id where u.id=:id";
                var result = conn.Query<TUsers>(sql, new { id = id });

                if (result.Count() > 0)
                {
                    return result.ToList();
                }
                return null;
            }
        }

            /// <summary>
            /// <summary>
            /// 查看用户
            /// </summary>
            /// <returns></returns>
            public List<TUsers> GetUsers()
            {
                using (OracleConnection conn = DapperHelper.GetConnString())
                {
                    conn.Open();
                string sql = @" select WMSYS.WM_CONCAT(r.name) as RoleName,u.id, u.username,u.password from T_Users u, user_role ur ,T_Role r 
 where  u.id=ur.user_id AND ur.role_id=r.id group by u.id, u.username,u.password";
                var t_UsersList = conn.Query<TUsers>(sql, null);
                    return t_UsersList.ToList<TUsers>();
                }
            }

            /// <summary>
            /// 用户登录
            /// </summary>
            /// <param name="userName"></param>
            /// <param name="passWord"></param>
            /// <returns></returns>
            public int Login(string userName, string passWord)
            {
                using (OracleConnection conn = DapperHelper.GetConnString())
                {
                    conn.Open();
                    string sql = @"select * from T_Users where UserName=:userName and PassWord=:passWord";
                    var list = conn.Query<TUsers>(sql, new { userName = userName, passWord = passWord }).ToList();
                if (list.Count() > 0)
                    return list[0].ID;

                    return 0;
                }
            }

            /// <summary>
            /// 修改用户
            /// </summary>
            /// <param name="users"></param>
            /// <returns></returns>
            public int UpdateUsers(TUsers users)
            {
                using (OracleConnection conn = DapperHelper.GetConnString())
                {
                    conn.Open();
                    string sql1 = @"select * from T_Users where UserName=:UserName";
                    var Roles = conn.Query<TUsers>(sql1, users);
                    int result = -1;
                    if (Roles.Count() == 0)
                    {
                        //修改角色
                        string sql = @"update T_Users set UserName=:UserName,PassWord=:PassWord,RoleId=:RoleId,RoleName=:RoleName where id=:id";
                        int result2 = conn.Execute(sql, users);

                        //获取角色id
                        string sql2 = ("select id from T_Users where UserName=:UserName");
                        var id = conn.Query<int>(sql2, users).FirstOrDefault();

                        var roles = users.RoleId.Split(',');

                        for (int i = 0; i < roles.Length; i++)
                        {
                            UserRole userRole = new UserRole();
                            userRole.User_Id = id;
                            userRole.Role_Id = Convert.ToInt32(roles[i]);
                            string sql3 = @"update User_Role set Role_Id=:Role_Id,User_Id=:User_Id where User_Id=:User_Id ";
                            result = conn.Execute(sql3, userRole);
                        }
                    }
                    return result;
                }
            }
        }
    }
