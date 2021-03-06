﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 订单详情表
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        public int FID { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int SID { get; set; }


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
        ///商品数量 
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public double Prices { get; set; }

        /// <summary>
        /// 价格单价
        /// </summary>
        public double FoodsPrice { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 订单支付状态
        /// </summary>
        public EnumNews OrderState { get; set; }

        /// <summary>
        /// 菜品图片
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        public string FoodName { get; set; }

        
    }
}
