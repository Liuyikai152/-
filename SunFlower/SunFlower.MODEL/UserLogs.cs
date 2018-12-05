using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 用户日志
    /// </summary>
   public class UserLogs
    {
        /// <summary>
        /// 用户日志ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 浏览店铺ID
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID{ get; set; }
    }
}
