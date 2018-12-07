using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;

namespace SunFlower.Api.Controllers
{
    public class UsersController : ApiController
    {
        UserService service = new UserService();

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

            int add = service.AddUsers(users);
            return add;

        }

        /// <summary>
        /// 显示用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetUsers()
        {

            var usersList = service.GetUsers();
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
             
            int delete = service.DeleteUsers(id);
            return delete;
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
            int update = service.UptdateUsers(users);
            return update;
        }

    }
}
