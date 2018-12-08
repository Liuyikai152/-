using SunFlower.MODEL;
using SunFlower.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Unity.Attributes;
using SunFlower.IServices;
namespace SunFlower.Api.Controllers
{
    public class User_AddersController : ApiController
    {

        [Dependency]
        public IUser_Adders User_Adders { get; set; }
        /// <summary>
        /// 查看用户地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<User_Adders> GetUser_Adders()
        {
            var user_AddersList = User_Adders.GetUser_Adders();
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
            var result = User_Adders.AddUserAdder(user_Adders);
            return result;
        }

        /// <summary>
        /// 删除用户地址
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteUserAdder(int ID)
        {
            var result = User_Adders.DeleteUserAdder(ID);
            return result;
        }

        /// <summary>
        /// 修改用户地址
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPut]
        public int UptdateUserAdder(User_Adders user_Adders)
        {
            int result = User_Adders.UptdateUserAdder(user_Adders);
            return result;
        }
    }
}
