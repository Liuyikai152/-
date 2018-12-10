using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 用户配送地址 
    /// </summary>
   public class User_Adders
    {
        /// <summary>
        /// 用户信息ID
        /// </summary>
       public int ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
       public int UserID { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///  用户性别
        /// </summary>
        public EnumNews UserGender { get; set; }

        /// <summary>
        ///是否为默认地址 
        /// </summary>
        public int IsDefault { get; set; }

        /// <summary>
        /// 地区名
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditTime { get; set; }
        
     
    }
}
