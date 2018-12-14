using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    public class Role
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 角色权限
        /// </summary>
        public string Permission { get; set; }
    }
}
