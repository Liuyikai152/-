using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    public class TUsers
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 权限路径
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; set; }
    }
}
