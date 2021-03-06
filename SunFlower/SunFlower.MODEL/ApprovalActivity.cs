﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
   public class ApprovalActivity
    {
        /// <summary>
        /// 审批活动ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 审批流程ID
        /// </summary>
        public int ProcessID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 审批节点ID
        /// </summary>
        public int NodeID { get; set; }
        public string NodeName { get; set; }
        /// <summary>
        /// 配置流程编码
        /// </summary>
        public string ProcessCode { get; set; }
        /// <summary>
        /// 审批角色部门
        /// </summary>
        public string RoleSector { get; set; }
        /// <summary>
        /// 审批角色ID
        /// </summary>
        public int ApprovalRoleID { get; set; }
        public string ResponsibleRole1 { get; set; }
        /// <summary>
        /// 下一步审批角色ID
        /// </summary>
        public int NextApprovalRoleID { get; set; }
        public string ResponsibleRole2 { get; set; }
        /// <summary>
        /// 审批人ID
        /// </summary>
        public int ApprovalUserID { get; set; }
        public string UserName1 { get; set; }
        /// <summary>
        /// 下一步审批人ID
        /// </summary>
        public int NextApprovalUserID { get; set; }
        public string UserName2 { get; set; }
        /// <summary>
        /// 流程角色ID
        /// </summary>
        public int ProcessRoleID { get; set; }
        /// <summary>
        /// 判断条件ID
        /// </summary>
        public int JudgmentID { get; set; }
        public int Conditions { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public int CondtionID { get; set; }
        public int Condtion { get; set; }
        /// <summary>
        /// 是否修改
        /// </summary>
        public int IsAllowModity { get; set; }
        /// <summary>
        /// 是否撤销
        /// </summary>
        public int IsAllowVersion { get; set; }
        /// <summary>
        /// 实际审批人
        /// </summary>
        public string ApprovalUser { get; set; }
        /// <summary>
        /// 审批意见
        /// </summary>
        public string ApprovalOpinion { get; set; }
        /// <summary>
        /// 实际审批状态
        /// </summary>
        public int TureCondtionID { get; set; }
        public int TureCondtion { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime ApprovalTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
