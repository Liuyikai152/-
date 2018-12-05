using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 菜品表
    /// </summary>
    public class Food
    {
        /// <summary>
        /// 菜品ID
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
        /// 菜品名
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// 菜品图片
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        public string FoodSummary { get; set; }

        /// <summary>
        /// 菜品价格
        /// </summary>
        public double FoodSprice { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sale { get; set; }

        /// <summary>
        /// 是否上架
        /// </summary>
        public EnumNews State { get; set; }

        /// <summary>
        /// 类别ID
        /// </summary>
        public int FoodTypeID { get; set; }
    }
}
