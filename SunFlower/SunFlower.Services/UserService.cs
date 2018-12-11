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
using System.Net.Http;
using CommonCache;
using Newtonsoft.Json;
namespace SunFlower.Services
{
    /// <summary>
    /// 用户实现表
    /// </summary>
    public class UserService : IUsers
    {

        /// <summary>
        /// 获取微信会话密钥
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Users Logins(string code)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
             Users users = new Users();
            HttpClient httpclient = new HttpClient();
            string appid = "wx8f1577e9e3d89359";
            string secret = "d7ce9d53b4a5ca191acc895cd7bbf7dc";
            httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = httpclient.PostAsync("https://api.weixin.qq.com/sns/jscode2session?appid=" + appid + "&secret=" + secret + "&js_code=" + code.ToString() + "&grant_type=authorization_code", null).Result;
            var result = "";
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
            httpclient.Dispose();
            var results = JsonConvert.DeserializeObject<Users>(result);
            users.OpenID = results.OpenID;
            users.Seeson_Key = results.Seeson_Key;//密钥
                                                  //if (RedisHelper.Get<Users>(encryptTicket) != null)
                                                  //{
                                                  //    return RedisHelper.Get<Users>(encryptTicket);
                                                  //}
                                                  //else
                                                  //{
                                                  //    using (OracleConnection oracleConnection = DapperHelper.GetConnString())
                                                  //    {
                var uc = conn.Query<Users>("select * from Users").ToList();
                    var client = uc.Where(m => m.OpenID.Equals(users.OpenID)).FirstOrDefault();//判断是否为已注册用户
                    if (client == null)
                    {
                      int i = conn.Execute(@"insert  into users(useraddressid,username, turename,userphone,createtime,upttime,wallet,usertypem,openid,seeson_key) values(:useraddressid,:username, :turename,:userphone,:createtime, :upttime,:wallet,:usertypem,:openid,:seeson_key)",users);
                        

                    }
                    RedisHelper.Set<Users>(users.Seeson_Key, users, DateTime.Now.AddMinutes(10));
                    return users;
                }
            }
        

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUsers(Users users)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {

                conn.Open();

                string sql = @"insert into users(useraddressid,username,turename,userphone,createtime,upttime,wallet,usertype) values(:useraddressid,:username,:turename,:userphone,:createtime,:upttime,:wallet,:usertype)";

                int result = conn.Execute(sql, users);

                return result;
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

                int result = conn.Execute(sql, new { id = id });

                return result;
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
                string sql = @"select a.turename,a.userphone,b.address from users a join user_adders b on a.id=b.userid where a.useraddressid=b.id";
                var UsersList = conn.Query<Users>(sql, null);
                if (UsersList != null)
                {
                    return UsersList.ToList();

                }
                return null;
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

                int result = conn.Execute(sql, users);

                return result;
            }
        }
    }
}
