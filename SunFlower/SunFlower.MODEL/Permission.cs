using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    public class Permission
    {
        /// <summary>
        /// 权限id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 页面名称
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 页面描述
        /// </summary>
        public string Discription { get; set; }

        /// <summary>
        /// 权限地址
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public string IsUser { get; set; }
    }
}
