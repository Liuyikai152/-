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
        public int AddApprovalActivity(int JudgmentID,int NodeID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                ProcessConfiguration pc = new ProcessConfiguration();

                string sql = @"select  *  from ProcessConfiguration where JudgmentID=:JudgmentID and NodeID=:NodeID";

                var configurationList = conn.Query<ProcessConfiguration>(sql, new { JudgmentID = JudgmentID, NodeID= NodeID }).FirstOrDefault();
               
                ApprovalActivity activity = new ApprovalActivity();
                activity.ProcessID = configurationList.ProcessID;
                activity.NodeID = configurationList.NodeID;
                activity.ProcessCode = configurationList.ProcessCode;
                activity.ApprovalRoleID = configurationList.ApprovalRoleID;
                activity.NextApprovalRoleID = configurationList.NextApprovalRoleID;
                activity.ApprovalUserID = configurationList.ApprovalUserID;
                activity.NextApprovalUserID = configurationList.NextApprovalUserID;
                activity.JudgmentID = configurationList.JudgmentID;
                activity.CondtionID = configurationList.CondtionID;
                activity.TureCondtionID = configurationList.CondtionID;
                activity.Creator = configurationList.Creator;
                activity.CreateTime = configurationList.CreateTime;
                string sql1 = @"insert into ApprovalActivity
            (processid,nodeid,processcode,approvalroleid,nextapprovalroleid,approvaluserid,nextapprovaluserid,judgmentid,condtionid,turecondtionid,creator,createtime)
            values
  (:processid,:nodeid,:processcode,:approvalroleid,:nextapprovalroleid,:approvaluserid,:nextapprovaluserid,:judgmentid,:condtionid,:turecondtionid,:creator,:createtime)";
                int result = conn.Execute(sql1, activity);
                return result;
            }
        }

        /// <summary>
        /// 显示待审批数据
        /// </summary>
        /// <returns></returns>
        public List<ApprovalActivity> GetApprovalActivity(int ApprovalUserID,int condtionid)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql1 = @"select * from ApprovalActivity where condtionid=0 and ApprovalUserID= :ApprovalUserID";
                var approvalActivityList1 = conn.Query<ApprovalActivity>(sql1, new { ApprovalUserID= ApprovalUserID }).FirstOrDefault();

                if(approvalActivityList1.ApprovalUserID== ApprovalUserID && approvalActivityList1!=null)
                {
                           string sql = @"
select p.id, p.processcode, p.creator,p.createtime,a.name,p.condtionid,a.isallowmodity,a.isallowversion,b.nodename,b.responsiblerole as responsiblerole1,b1.responsiblerole
 as responsiblerole2,u.username as username1,u1.username as username2,c.conditions,s.condtion as condtion ,s1.condtion as turecondtion
from approvalactivity p
 left join Approvalprocess a on(p.processid=a.id)
 left join approvalnode b  on(p.approvalroleid=b.id)
 left join approvalnode b1 on(p.nextapprovalroleid=b1.id)
left join t_users u on(p.approvaluserid=u.id)
 left join t_users u1 on(p.nextapprovaluserid=u1.id)  
left join approvalconditions c on(p.judgmentid=c.id)
 left join approvalstatus s on(p.condtionid=s.id)
 left join approvalstatus s1 on(p.turecondtionid=s1.id) where ApprovalUserID=:ApprovalUserID and condtionid=condtionid";
                    var approvalActivityList = conn.Query<ApprovalActivity>(sql, new { ApprovalUserID = ApprovalUserID });
                    return approvalActivityList.ToList<ApprovalActivity>();
                }


                return null;
               



              
            }
        }


        /// <summary>
        /// 审批实现
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public int UpdateApprovalActivity(int ID, int CondtionID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update ApprovalActivity set  CondtionID=:CondtionID where ID=:ID";
                var result = conn.Execute(sql, new { ID = ID, CondtionID = CondtionID });

               

                return result;
            }
        }
    }
}
