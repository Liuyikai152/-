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
        [Route("GetUserAdders")]
        public List<User_Adders> GetUserAdders()
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
        [Route("AddUserAdder")]
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
        [HttpGet]
        [Route("DeleteUserAdder")]
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
        [HttpPost]
        [Route("UptdateUserAdder")]
        public int UptdateUserAdder(User_Adders user_Adders)
        {
            int result = User_Adders.UptdateUserAdder(user_Adders);
            return result;
        }

        /// <summary>
        /// 根据用户查询地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserAddersByIs")]
        public User_Adders GetUserAddersByIs(int userID,int isDefault)
        {
            var userAddersList = User_Adders.GetUserAdder().Where(n=>n.IsDefault.Equals(isDefault)&&n.UserID.Equals(userID)).FirstOrDefault();
            return userAddersList;
        }

        /// <summary>
        /// 根据用户查询地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserAddersByID")]
        public List<User_Adders> GetUserAddersByID(int userID)
        {
            var userAddersList = User_Adders.GetUserAdder().Where(n => n.UserID.Equals(userID)).ToList();
            return userAddersList;
        }
    }
}
