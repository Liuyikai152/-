using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 收藏表
    /// </summary>
    public class Collect
    {
        /// <summary>
        /// 收藏编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 商家店铺头像
        /// </summary>
        public string StoreImg { get; set; }
    }
}
