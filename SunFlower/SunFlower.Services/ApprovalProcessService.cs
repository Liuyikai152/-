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
    /// 流程实现类
    /// </summary>
    public class ApprovalProcessService:IApprovalProcess
    {
        /// <summary>
        /// 添加审批
        /// </summary>
        /// <param name="collect"></param>
        /// <returns></returns>
        public int AddApprovalProcess(ApprovalProcess approvalProcess)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into ApprovalProcess(name,isallowmodity,isallowversion,creator,createtime) values(:name,:isallowmodity,:isallowversion,:creator,:createtime)";
                approvalProcess.CreateTime = DateTime.Now;
                int result = conn.Execute(sql, approvalProcess);
                return result;
            }
        }

        /// <summary>
        /// 显示审批
        /// </summary>
        /// <returns></returns>
        public List<ApprovalProcess> GetApprovalProcess()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from ApprovalProcess");
                var approvalProcessList = conn.Query<ApprovalProcess>(sql, null);
                return approvalProcessList.ToList<ApprovalProcess>();
            }
        }

        /// <summary>
        /// 删除流程
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteApprovalProcess(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"delete from ApprovalProcess where ID=:ID";
                int result = conn.Execute(sql, new { ID = id });
                return result;
            }
        }

        /// <summary>
        /// 修改流程
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public int UpdateApprovalProcess(Food approvalProcess)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update ApprovalProcess set name =:name,isallowmodity =:isallowmodity,isallowversion =:isallowversion,creator =:creator where id =:id";
                var result = conn.Execute(sql, approvalProcess);
                return result;
            }
        }

        /// <summary>
        /// 获取单个审批
        /// </summary>
        /// <returns></returns>
        public List<ApprovalProcess> GetApprovalProcessByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select id,name,isallowmodity, isallowversion, creator from ApprovalProcess where id=:id");
                var approvalProcessList = conn.Query<ApprovalProcess>(sql, new { id = id });
                return approvalProcessList.ToList<ApprovalProcess>();
            }
        }
    }
}
