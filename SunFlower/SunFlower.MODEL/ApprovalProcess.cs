using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 审批流程表
    /// </summary>
   public class ApprovalProcess
    {
        /// <summary>
        /// 流程ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否允许修改
        /// </summary>
        public int IsAllowModity { get; set; }

        /// <summary>
        /// 是否允许撤销
        /// </summary>
        public int IsAllowVersion { get; set; }

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
