using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
     public enum EnumNews
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        Domestic,

        /// <summary>
        /// 商家
        /// </summary>
        Merchant,

        /// <summary>
        /// 超级管理员
        /// </summary>
        Manager,

        /// <summary>
        /// 先生
        /// </summary>
        Mr,

        /// <summary>
        /// 女士
        /// </summary>
        Lady,

        /// <summary>
        /// 待审核
        /// </summary>
        Authstr,

        /// <summary>
        /// 通过
        /// </summary>
        Pass,

        /// <summary>
        /// 驳回
        /// </summary>
        turndown,

        /// <summary>
        /// 营业
        /// </summary>
        Business,

        /// <summary>
        /// 停业
        /// </summary>
        Classdown,

        /// <summary>
        /// 支付
        /// </summary>
        Pay,

        /// <summary>
        /// 待支付
        /// </summary>
        UnPay,

        /// <summary>
        /// 配送
        /// </summary>
        Delivery,

        /// <summary>
        /// 非常好
        /// </summary>
        VeryGood,


        /// <summary>
        /// 较好
        /// </summary>
        Good,

        /// <summary>
        /// 一般
        /// </summary>
        Ordinary,

        /// <summary>
        /// 较差
        /// </summary>
        Bad,

        /// <summary>
        /// 非常错
        /// </summary>
        SoBad,

        /// <summary>
        /// 接单
        /// </summary>
        Order,

        /// <summary>
        /// 拒单
        /// </summary>
        Single,

        /// <summary>
        /// 上架
        /// </summary>
        Putaway,

        /// <summary>
        /// 下架
        /// </summary>
        Soldout,


    }
}
