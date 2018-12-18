using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 审批表
    /// </summary>
    public class Audits
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        public int BusinessID { get; set; }

        /// <summary>
        /// 审批名称
        /// </summary>
        public string AuditName { get; set; }
        
        /// <summary>
        /// 审批描述
        /// </summary>
        public string AuditContext { get; set; }
    }
}
