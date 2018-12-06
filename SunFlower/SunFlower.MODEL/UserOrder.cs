using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{

    /// <summary>
    /// 订单表
    /// </summary>
   public  class UserOrder
    {
        /// <summary>
        /// 订单表ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 菜品编号
        /// </summary>
        public string FoodNumber { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber { get; set; }
        
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNumber { get; set; }
        
        /// <summary>
        ///购物车ID 
        /// </summary>
        public int TrolleyID { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public int AddersID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int Num { get; set; }

        /// <总金额
        /// </summary>
        public Double OrderMoney { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 订单支付状态
        /// </summary>
        public EnumNews OrderState { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public EnumNews StoreOrderState { get; set; }

    }
}
