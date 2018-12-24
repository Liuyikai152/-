using SunFlower.IServices;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using Unity.Attributes;
namespace SunFlower.Api.Controllers
{
    [RoutePrefix("Permission")]
    public class PermissionController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IPermission t_Permission { get; set; }

        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPermissions")]
        public List<Permission> GetPermissions()
        {
            var tPermissionList = t_Permission.GetPermissions();
            return tPermissionList;
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route("DeletePermission")]
        [HttpGet]
        public int DeletePermission(int ID)
        {
            var result = t_Permission.DeletePermission(ID);
            return result;
        }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddPermission(Permission permission)
        {
            var result = t_Permission.AddPermission(permission);
            return result;
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        [Route("UpdatePermission")]
        [HttpPost]
        public int UpdatePermission(Permission  permission)
        {
            int result = t_Permission.UpdatePermission(permission);
            return result;
        }

        /// <summary>
        /// 获取角色id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public List<Permission> GetByID(int id)
        {
            var result = t_Permission.GetByID(id);
            return result;
        }


        private const int PAGESIZE = 4;
        [HttpGet]
        [Route("GetPermission")]
        public PageBox GetPermission(int Page = 1)
        {
            List<Permission> tPermissionList = t_Permission.GetPermissions();
            PageBox pagebox = new PageBox();
            pagebox.PageIndex = Page;
            pagebox.PageCount = tPermissionList.Count / PAGESIZE + (tPermissionList.Count % PAGESIZE == 0 ? 0 : 1);
            pagebox.Data = tPermissionList.Skip((Page - 1) * PAGESIZE).Take(PAGESIZE);
            return pagebox;
        }
    }
}
