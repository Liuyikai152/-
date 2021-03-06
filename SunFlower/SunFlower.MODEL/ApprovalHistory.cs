﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
   public class ApprovalHistory
    {
        /// <summary>
        /// 审批记录ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 审批活动ID
        /// </summary>
        public int ActivityID { get; set; }
        /// <summary>
        /// 审批流程ID
        /// </summary>
        public int ProcessID { get; set; }
        /// <summary>
        /// 审批节点ID
        /// </summary>
        public int NodeID { get; set; }
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
        /// <summary>
        /// 下一步审批角色ID
        /// </summary>
        public int NextApprovalRoleID { get; set; }
        /// <summary>
        /// 审批人ID
        /// </summary>
        public int ApprovalUserID { get; set; }
        /// <summary>
        /// 下一步审批人ID
        /// </summary>
        public int NextApprovalUserID { get; set; }
        /// <summary>
        /// 流程角色ID
        /// </summary>
        public int ProcessRoleID { get; set; }
        /// <summary>
        /// 判断条件ID
        /// </summary>
        public int JudgmentID { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
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
        public int TureCondtion { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime ApprovalTime { get; set; }
        /// <summary>
        /// 审批活动记录创建人
        /// </summary>
        public string ActivityCreator { get; set; }
        /// <summary>
        /// 审批活动记录创建时间
        /// </summary>
        public DateTime ActivityCreateTime { get; set; }
        /// <summary>
        /// 审批历史记录创建时间
        /// </summary>
        public DateTime HistoryCreateTime { get; set; }
    }
}
