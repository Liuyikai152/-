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
       
        public int AddUsers()
        {
            Users users = new Users();
            users.TureName = "李四";
            users.UserAddressID = 2;
            users.UserName = "lisi";
            users.UserPhone = "18678978978";
            users.UserType =2;
            users.Wallet = 32.3;
            users.CreateTime = DateTime.Now;
           
            int Add = service.AddUsers(users);
            return Add;
                
        }

        /// <summary>
        /// 显示用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetUsers()
        {
            
            var UsersList = service.GetUsers();
            return UsersList;
            
        }
    }
}
