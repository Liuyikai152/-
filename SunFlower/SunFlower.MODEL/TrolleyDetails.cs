using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 购物车明细表
    /// </summary>
   public class TrolleyDetails
    {
        /// <summary>
        /// 购物车明细ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 购物车编号
        /// </summary>
        public string TrolleyNumber { get; set; }

        /// <summary>
        /// 菜品编号
        /// </summary>
        public string FoodNumber { get; set; }

        /// <summary>
        /// 人员编号
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public Double Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public Double Prices { get; set; }

        /// <summary>
        /// 菜品图片
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// 菜品价格
        /// </summary>
        public string FoodSprice { get; set; }
    }
}
