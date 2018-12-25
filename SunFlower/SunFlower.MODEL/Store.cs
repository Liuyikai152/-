using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 商家表
    /// </summary>
    public class Store
    {
        /// <summary>
        /// 商家ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 商家店铺编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 商家店铺名称
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 商家店铺头像
        /// </summary>
        public string StoreImg { get; set; }

        /// <summary>
        /// 商家店铺实体图
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 商家店铺具体位置
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 商家电话
        /// </summary>
        public string StorePhone { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public EnumNews Auditing { get; set; }

        /// <summary>
        /// 开店状态
        /// </summary>
        public EnumNews State { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditTime { get; set; }

        /// <summary>
        /// 日销量
        /// </summary>
        public int DaySale { get; set; }

        /// <summary>
        /// 日营业额
        /// </summary>
        public double DayMoney { get; set; }

        /// <summary>
        /// 商铺描述
        /// </summary>
        public string Conntent { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public string StoreType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
    }
}
