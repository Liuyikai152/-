using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 优惠表
    /// </summary>
    public class Discounts
    {
        /// <summary>
        /// 优惠表ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public double Discountsint { get; set; }

        /// <summary>
        /// 满减金额
        /// </summary>
        public double Money_Off { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditTime { get; set; }

    }
}
