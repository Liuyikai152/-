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
    public class ApprovalActivityService:IApprovalActivity
    {
        /// <summary>
        /// 添加审批活动
        /// </summary>
        /// <returns></returns>
        public int AddApprovalActivity()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                ProcessConfiguration pc = new ProcessConfiguration();

                string sql = @"select  *  from ProcessConfiguration where JudgmentID=1 and NodeID=1";

                var configurationList = conn.Query<ProcessConfiguration>(sql, null).FirstOrDefault();
                ApprovalActivity activity = new ApprovalActivity();
                activity.ProcessID = configurationList.ProcessID;
                activity.NodeID = configurationList.NodeID;
                activity.ProcessCode = configurationList.ProcessCode;
                activity.ApprovalRoleID = configurationList.ApprovalRoleID;
                activity.NextApprovalRoleID = configurationList.NextApprovalRoleID;
                activity.ApprovalUserID = configurationList.ApprovalUserID;
                activity.TureCondtion = configurationList.ApprovalUserID;
                activity.NextApprovalUserID = configurationList.NextApprovalUserID;
                activity.JudgmentID = configurationList.JudgmentID;
                activity.CondtionID = configurationList.CondtionID;
                activity.TureCondtionID = configurationList.CondtionID;
                activity.Creator = configurationList.Creator;
                activity.CreateTime = configurationList.CreateTime;

                string sql1 = @"insert into ApprovalActivity
(processid,turecondtion, nodeid,processcode,approvalroleid,nextapprovalroleid,approvaluserid,nextapprovaluserid,judgmentid,condtionid,creator,createtime)
values
(:processid,turecondtion,:nodeid,:processcode,:approvalroleid,:nextapprovalroleid,:approvaluserid,:nextapprovaluserid,:judgmentid,:condtionid,:creator,:createtime)";

                int result = conn.Execute(sql1, activity);
                return result;
            }
        }
        /// <summary>
        /// 显示待审批数据
        /// </summary>
        /// <returns></returns>
        public List<ApprovalActivity> GetApprovalActivity()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"
select p.id, p.processcode, p.creator,p.createtime,a.name,a.isallowmodity,a.isallowversion,b.nodename,b.responsiblerole as responsiblerole1,b1.responsiblerole
 as responsiblerole2,u.username as username1,u1.username as username2,c.conditions,s.condtion as condtion ,s1.condtion as turecondtion
from approvalactivity p
 left join Approvalprocess a on(p.processid=a.id)
 left join approvalnode b  on(p.approvalroleid=b.id)
 left join approvalnode b1 on(p.nextapprovalroleid=b1.id)
left join t_users u on(p.approvaluserid=u.id)
 left join t_users u1 on(p.nextapprovaluserid=u1.id)  
left join approvalconditions c on(p.judgmentid=c.id)
 left join approvalstatus s on(p.condtionid=s.id)
 left join approvalstatus s1 on(p.turecondtionid=s1.id)";
                var approvalActivityList = conn.Query<ApprovalActivity>(sql, null);
                return approvalActivityList.ToList<ApprovalActivity>();
            }
        }

        public int UpdateApprovalActivity(ApprovalActivity approvalActivity)
        {
            throw new NotImplementedException();
        }
    }
}
