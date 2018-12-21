using SunFlower.IServices;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;




namespace SunFlower.Api.Controllers
{
   [RoutePrefix("TUsers")]
    public class TUsersController : ApiController
    {
        [Unity.Attributes.Dependency]
        public ITUsers Users { get; set; }

        /// <summary>
        /// 查看角色
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUsers")]
        public List<TUsers> GetUsers()
        {
            var t_UsersList = Users.GetUsers();
            return t_UsersList;
        }
        
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        [HttpGet]
        public int Login(string userName, string passWord)
        {
            int result = Users.Login(userName, passWord);
            return result;
        }
        
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route("DeleteUsers")]
        [HttpGet]
        public int DeleteUsers(int ID)
        {
            var result = Users.DeleteUsers(ID);
            return result;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        [Route("AddTUsers")]
        [HttpPost]
        public int AddTUsers(string userName,string passWord,string roleId)
        {
            TUsers users = new TUsers();
            users.UserName = userName;
            users.PassWord = passWord;
            users.RoleId = roleId;
            var result = Users.AddUsers(users);
            return result;
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        [Route("UpdateUsers")]
        [HttpPost]
        public int UpdateUsers(string userName, string passWord, string roleId,int id)
        {
            TUsers users = new TUsers();
            users.UserName = userName;
            users.PassWord = passWord;
            users.RoleId = roleId;
            users.ID = id;
            var result = Users.UpdateUsers(users);
            return result;
        }

        /// <summary>
        /// 获取角色id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public List<TUsers> GetByID(int id)
        {
            var result = Users.GetByID(id);
            return result;
        }

        /// <summary>
        /// 获取权限路径
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetPermissiomUrl")]
        [HttpGet]
        public List<TUsers> GetPermissiomUrl(int id)
        {
            var result = Users.GetPermissiomUrl(id);
            return result;
        }       
    }
}
