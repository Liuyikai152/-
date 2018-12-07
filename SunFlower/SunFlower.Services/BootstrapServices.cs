using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.MODEL;
using SunFlower.IServices;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;

namespace SunFlower.Services
{
    /// <summary>
    /// 轮播图实现类
    /// </summary>
    public class BootstrapServices : IBootstrap
    {
        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Bootstrap> GetBootstraps()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from (select Store.FileName from Bootstrap join Store on(Bootstrap.Storenumber=Store.Storenumber) order by Store.DaySale desc) where rownum<=5");
                var bootstrapsList = conn.Query<Bootstrap>(sql, null);
                return bootstrapsList.ToList<Bootstrap>();
            }
        }
    }
}
