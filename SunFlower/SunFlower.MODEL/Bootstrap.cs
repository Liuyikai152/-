using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 轮播图类
    /// </summary>
    public class Bootstrap
    {
        /// <summary>
        /// 轮播图ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 轮播图
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// 商铺编号
        /// </summary>
        public string StoreNumber { get; set; }
    }
}
