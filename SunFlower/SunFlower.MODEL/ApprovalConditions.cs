using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{

   public class ApprovalConditions
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 审批条件
        /// </summary>
        public string Conditions { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public string Sort { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 编辑人
        /// </summary>
        public string Editor { get; set; }
        /// <summary>
        /// 编辑时间
        /// </summary>
        public string Edittime { get; set; }
      
    }
}
