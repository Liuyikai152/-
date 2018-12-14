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


        [HttpGet]
        [Route("GetUsers")]
        public List<TUsers> GetUsers()
        {
            var t_UsersList = Users.GetUsers();
            return t_UsersList;
        }
        
        [HttpGet]
        public int Login(string userName, string passWord)
        {
            int result = Users.Login(userName, passWord);
            return result;
        }
        
        [Route("DeleteUsers")]
        [HttpGet]
        public int DeleteUsers(int ID)
        {
            var result = Users.DeleteUsers(ID);
            return result;
        }

        
        [HttpPost]
        public int AddT_Users(TUsers  t_Users)
        {
            var result = Users.AddUsers(t_Users);
            return result;
        }

        [Route("UpdateUsers")]
        [HttpPost]
        public int UpdateUsers(TUsers  t_Users)
        {
            int result = Users.UpdateUsers(t_Users);
            return result;
        }

    }
}
