using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunFlower.Api.Controllers
{
    using System.Data;
    using SunFlower.MODEL;
    using SunFlower.Services;
    using Unity.Attributes;
    using SunFlower.IServices;
    [RoutePrefix("ProcessConfiguration")]
    public class ProcessConfigurationController : ApiController
    {
        [Dependency]
        public IProcessConfiguration ProcessConfiguration { get; set; }

        [Dependency]
        public IApprovalActivity ApprovalActivity { get; set; }


        /// <summary>
        /// 添加流程配置
        /// </summary>
        /// <param name="collect"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddConfiguration")]
        public int AddConfiguration(ProcessConfiguration processConfiguration)
        {
            var result = ProcessConfiguration.AddConfiguration(processConfiguration);
            if (result>0) {
                ApprovalActivity.AddApprovalActivity(processConfiguration.JudgmentID,processConfiguration.NodeID);
            }
            return result;
        }

        /// <summary>
        /// 显示流程配置
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProcessConfiguration")]
        public List<ProcessConfiguration> GetProcessConfiguration()
        {
            var result = ProcessConfiguration.GetProcessConfiguration();
            return result;
        }

        /// <summary>
        /// 删除流程配置
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteConfiguration")]
        public int DeleteConfiguration(int id)
        {
            var result = ProcessConfiguration.DeleteConfiguration(id);
            return result;
        }
    }
}
