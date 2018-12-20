using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
   public class ApprovalStatus
    {
        /// <summary>
        /// 状态ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        public int Condtion { get; set; }
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
