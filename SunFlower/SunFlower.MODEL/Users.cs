using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// 地址ID
        /// </summary>
        public int UserAddressID { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TureName { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UptTime { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public double Wallet { get; set; }

        /// <summary>
        /// 用户类别
        /// </summary>
        public EnumNews UserType { get; set; }

    }
}
