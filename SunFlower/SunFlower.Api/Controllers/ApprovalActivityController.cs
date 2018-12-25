using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;
using Unity.Attributes;
using SunFlower.IServices;

namespace SunFlower.Api.Controllers
{
    [RoutePrefix("ApprovalActivity")]
    public class ApprovalActivityController : ApiController
    {
        [Dependency]
        public IApprovalActivity ApprovalActivity { get; set; }

        /// <summary>
        /// 添加审核活动
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddApprovalActivity")]
        public int AddApprovalActivity(int JudgmentID, int NodeID)
        {
            var result = ApprovalActivity.AddApprovalActivity(JudgmentID,NodeID);
            return result;
        }

        /// <summary>
        /// 显示待审批数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalActivity")]
        public List<ApprovalActivity> GetApprovalActivity(int ApprovalUserID)
        {
            var approvalActivityList = ApprovalActivity.GetApprovalActivity(ApprovalUserID);
            return approvalActivityList;
        }

        /// <summary>
        /// 审批实现
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UpdateApprovalActivity")]
        public int UpdateApprovalActivity(int ID, int CondtionID)
        {
            var result = ApprovalActivity.UpdateApprovalActivity(ID, CondtionID);
            return result;
        }

    }
}
