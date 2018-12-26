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
    [RoutePrefix("ApprovalProcess")]
    public class ApprovalProcessController : ApiController
    {
        [Dependency]
        public IApprovalProcess ApprovalProcess { get; set; }

        [Dependency]
        public IApprovalActivity ApprovalActivity { get; set; }

        /// <summary>
        /// 显示审批
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalProcess")]
        public List<ApprovalProcess> GetApprovalProcess()
        {
            var approvalProcessList = ApprovalProcess.GetApprovalProcess();
            return approvalProcessList;
        }
        /// <summary>
        /// 删除审批
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteApprovalProcess")]
        public int DeleteApprovalProcess(int id)
        {
            var result = ApprovalProcess.DeleteApprovalProcess(id);
            return result;
        }

        /// <summary>
        /// 添加流程
        /// </summary>
        /// <param name="approvalProcess"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddApprovalProcess")]
        public int AddApprovalProcess(ApprovalProcess approvalProcess)
        {
            var result = ApprovalProcess.AddApprovalProcess(approvalProcess);
            if (result > 0)
            {
                ApprovalActivity.AddApprovalActivity();
            }
            return result;
        }

        /// <summary>
        /// 修改流程
        /// </summary>
        /// <param name="approvalProcess"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateApprovalProcess")]
        public int UpdateApprovalProcess(ApprovalProcess approvalProcess)
        {
            var result = ApprovalProcess.UpdateApprovalProcess(approvalProcess);
            return result;
        }

        /// <summary>
        /// 获取单个审批
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalProcessByID")]
        public List<ApprovalProcess> GetApprovalProcessByID(int id)
        {
            var result = ApprovalProcess.GetApprovalProcessByID(id);
            return result;
        }
    }
}
