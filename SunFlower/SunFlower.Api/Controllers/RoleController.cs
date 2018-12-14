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


        [HttpGet]
        [Route("GetRoles")]
        public List<Role> GetRoles()
        {
            var t_UsersList = t_Role.GetRoles();
            return t_UsersList;
        }

     
        [Route("DeleteRole")]
        [HttpGet]
        public int DeleteRole(int ID)
        {
            var result = t_Role.DeleteRole(ID);
            return result;
        }


        [HttpPost]
        public int AddRole(Role  role)
        {
            var result = t_Role.AddRole(role);
            return result;
        }

        [Route("UpdateRole")]
        [HttpPost]
        public int UpdateRole(Role  role)
        {
            int result = t_Role.UpdateRole(role);
            return result;
        }

        [Route("GetByID")]
        [HttpGet]
        public List<Role> GetByID(int id)
        {
            var result = t_Role.GetByID(id);
            return result;
        }

    }
}
