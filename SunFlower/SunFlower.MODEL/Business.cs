using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 业务表
    /// </summary>
    public class Business
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// 业务描述
        /// </summary>
        public string BusinessContext { get; set; }

    }
}
