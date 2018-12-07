using SunFlower.MODEL;
using SunFlower.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunFlower.Api.Controllers
{
    public class User_AddersController : ApiController
    {
        User_AddersService services = new User_AddersService();
        /// <summary>
        /// 查看用户地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<User_Adders> GetUser_Adders()
        {
            var user_AddersList = services.GetUser_Adders();
            return user_AddersList;
        }

        /// <summary>
        /// 添加用户地址
        /// </summary>
        /// <param name="user_Adders"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddUserAdder(User_Adders user_Adders)
        {
            var add = services.AddUserAdder(user_Adders);
            return add;
        }

        /// <summary>
        /// 删除用户地址
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteUserAdder()
        {
            User_Adders user_Adders = new User_Adders();
            user_Adders.ID = 2;
            var delete = services.DeleteUserAdder(user_Adders.ID);
            return delete;
        }

        /// <summary>
        /// 修改用户地址
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPut]
        public int UptdateUserAdder(User_Adders user_Adders)
        {
            int uptdate = services.UptdateUserAdder(user_Adders);
            return uptdate;
        }
    }
}
