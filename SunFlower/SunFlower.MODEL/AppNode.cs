using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 审批节点表
    /// </summary>
    public class AppNode
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 审批ID
        /// </summary>
        public int AuditID { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        public string NodeContext { get; set; }

    }
}
