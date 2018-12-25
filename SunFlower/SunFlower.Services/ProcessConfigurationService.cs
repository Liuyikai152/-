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
    public class ProcessConfigurationService:IProcessConfiguration
    {
        /// <summary>
        /// 添加流程配置
        /// </summary>
        /// <param name="collect"></param>
        /// <returns></returns>
        public int AddConfiguration(ProcessConfiguration processConfiguration)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into ProcessConfiguration(processid, nodeid,processcode,approvalroleid,nextapprovalroleid,approvaluserid,nextapprovaluserid,judgmentid,condtionid,creator,createtime)values(:processid,:nodeid,:processcode,:approvalroleid,:nextapprovalroleid,:approvaluserid,:nextapprovaluserid,:judgmentid,:condtionid,:creator,:createtime)";
                processConfiguration.CreateTime = DateTime.Now;
                int result = conn.Execute(sql, processConfiguration);
                return result;
            }
        }

        /// <summary>
        /// 显示流程配置
        /// </summary>
        /// <returns></returns>
        public List<ProcessConfiguration> GetProcessConfiguration()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select p.id, p.processcode,p.creator,p.createtime,a.name,b.nodename,b.responsiblerole as responsiblerole1,b1.responsiblerole as responsiblerole2,u.username as username1  ,u1.username as username2 ,
c.conditions,s.condtion from ProcessConfiguration p left join Approvalprocess a on(p.processid=a.id)left join approvalnode b  on(p.approvalroleid=b.id)
 left join approvalnode b1 on(p.nextapprovalroleid=b1.id)
left join t_users u 
 on(p.approvaluserid=u.id)
 left join t_users u1 
 on(p.nextapprovaluserid=u1.id)  
left join approvalconditions c 
 on(p.judgmentid=c.id)
 left join approvalstatus s
 on(p.condtionid=s.id)";
                var processConfigurationList = conn.Query<ProcessConfiguration>(sql, null);
                return processConfigurationList.ToList<ProcessConfiguration>();
            }
        }

        /// <summary>
        /// 删除流程配置
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteConfiguration(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"delete from ProcessConfiguration where id=:id";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }
    }
}
