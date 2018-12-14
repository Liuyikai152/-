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


        [HttpGet]
        [Route("GetPermissions")]
        public List<Permission> GetPermissions()
        {
            var t_PermissionList = t_Permission.GetPermissions();
            return t_PermissionList;
        }


        [Route("DeletePermission")]
        [HttpGet]
        public int DeletePermission(int ID)
        {
            var result = t_Permission.DeletePermission(ID);
            return result;
        }


        [HttpPost]
        public int AddPermission(Permission permission)
        {
            var result = t_Permission.AddPermission(permission);
            return result;
        }


        [Route("UpdatePermission")]
        [HttpPost]
        public int UpdatePermission(Permission  permission)
        {
            int result = t_Permission.UpdatePermission(permission);
            return result;
        }
    }
}
