using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 地区表
    /// </summary>
    public class Area
    {
        /// <summary>
        /// 地区ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 地区名
        /// </summary>
        public  string AreaName { get; set; }

        /// <summary>
        /// 地区类别编号
        /// </summary>
        public int Pid { get; set; }
    }
}
