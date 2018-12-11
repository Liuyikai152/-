using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;
using SunFlower.IServices;
using Unity.Attributes;
using CommonCache;

namespace SunFlower.Api.Controllers
{
    [RoutePrefix("Users")]
    public class UsersController : ApiController
    {

       
        [Dependency]
        public  IUsers Users  { get; set; }

        [HttpGet]
        [Route("Login")]
        public Users Logins(string code)
        {
            var client = Users.Logins(code);
            return client;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]

        public int AddUsers(Users users)
        {
            //Users users = new Users();
            //users.TureName = "李四";
            //users.UserAddressID = 2;
            //users.UserName = "lisi";
            //users.UserPhone = "18678978978";
            //users.UserType =2;
            //users.Wallet = 32.3;
            //users.CreateTime = DateTime.Now;

            int result = Users.AddUsers(users);
            return result;

        }

        /// <summary>
        /// 显示用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetUsers()
        {

            var usersList = Users.GetUsers();
            return usersList;

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteUser(int id)
        {
             
            int result = Users.DeleteUsers(id);
            return result;
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        public int UpdateUser(Users users)
        {
            //Users users = new Users();
            //users.ID =1;
            //users.TureName = "李阳丹";
            //users.UserAddressID = 2;
            //users.UserName = "liyangdan";
            //users.UserPhone = "18394568379";
            //users.UserType = 2;
            //users.Wallet = 32.3;
            //users.CreateTime = DateTime.Now;
            int result = Users.UptdateUsers(users);
            return result;
        }

    }
}
