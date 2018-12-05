﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 菜品编号
        /// </summary>
        public string FoodNumber { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string Money { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public int  AddressID { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


    }
}
