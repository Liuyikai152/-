using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SunFlower.MODEL;
using SunFlower.Services;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;

using Unity.Attributes;
using SunFlower.IServices;
namespace SunFlower.Api.Controllers
{
    public class UserLogsController : ApiController
    {
        [Dependency]
        public IUserLogs UserLogs { get; set; }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="userLogs"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddLogs(UserLogs userLogs)
        {

            int result = UserLogs.AddLogs(userLogs);
                return result;
        
        }

        /// <summary>
        /// 查看日志
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<UserLogs> GetUserLogs()
        {
            var userLogsList = UserLogs.GetUserLogs();
            return userLogsList;
        }

    }
}
