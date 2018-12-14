using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    public class RolePermission
    {
        /// <summary>
        /// id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public int Role_Id { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public int Permission_Id { get; set; }
    }
}
