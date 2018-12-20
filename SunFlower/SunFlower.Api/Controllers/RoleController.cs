using SunFlower.IServices;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunFlower.Api.Controllers
{
   [RoutePrefix("Role")]
    public class RoleController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IRole  t_Role { get; set; }

        /// <summary>
        /// 查看权限
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoles")]
        public List<Role> GetRoles()
        {
            var t_UsersList = t_Role.GetRoles();
            return t_UsersList;
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route("DeleteRole")]
        [HttpGet]
        public int DeleteRole(int ID)
        {
            var result = t_Role.DeleteRole(ID);
            return result;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("AddRole")]
        [HttpPost]
        public int AddRole(string roleName,string pId,string description)
        {
            Role role = new Role();
            role.Name = roleName;
            role.Pid = pId;
            role.Description = description;
            var result = t_Role.AddRole(role);
            return result;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("UpdateRole")]
        [HttpPost]
        public int UpdateRole(string roleName, string pId, string description,int id)
        {
            Role role = new Role();
            role.Name = roleName;
            role.Pid = pId;
            role.Description = description;
            role.ID = id;
            var result = t_Role.UpdateRole(role);
            return result;
        }

        /// <summary>
        /// 获取角色id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public List<Role> GetByID(int id)
        {
            var result = t_Role.GetByID(id);
            return result;
        }

    }
}
