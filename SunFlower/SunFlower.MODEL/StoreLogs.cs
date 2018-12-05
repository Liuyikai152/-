using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 商家日志表
    /// </summary>
   public class StoreLogs
    {
        /// <summary>
        /// 商家日志ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 商家店铺ID
        /// </summary>
        public int StoreID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 浏览的用户ID
        /// </summary>
        public int UserID { get; set; }
    }
}
