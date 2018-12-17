using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 购物车表
    /// </summary>
    public class Trolley
    {
        /// <summary>
        /// 购物车ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 购物车编号
        /// </summary>
        public string TrolleyNumber { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber{ get; set; }

        /// <summary>
        /// 菜品编号
        /// </summary>
        public string FoodNumber { get; set; }

        /// <summary>
        /// 人员编号
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 菜品价格
        /// </summary>
        public Double Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string AddressID { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string StoreName { get; set; }



        /// <summary>
        /// 店铺图片
        /// </summary>
        public string StoreImg { get; set; }


        /// <summary>
        /// 菜品图片
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 菜品价格
        /// </summary>
        public double FoodSprice { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        public string FoodName { get; set; }
      

    }
}
