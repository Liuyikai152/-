using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunFlower.Api.Controllers
{
    using SunFlower.MODEL;
    using SunFlower.Services;
    using Oracle.DataAccess.Client;
    using Oracle.DataAccess;

    public class StoreLogsController : ApiController
    {
        StoreLogsService servce = new StoreLogsService();

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="storeLogs"></param>
        /// <returns></returns>
        public int AddStoreLogs(StoreLogs storeLogs)
        {
            int result = servce.AddStoreLogs(storeLogs);
            return result;
        }

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <returns></returns>
        public List<StoreLogs> GetStoreLogs()
        {
            var stireLogsList = servce.GetStoreLogs();
            return stireLogsList;
        }
    }
}
