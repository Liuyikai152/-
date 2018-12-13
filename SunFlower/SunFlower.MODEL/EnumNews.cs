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
        /// 普通用户0
        /// </summary>
        Domestic,

        /// <summary>
        /// 商家1
        /// </summary>
        Merchant,

        /// <summary>
        /// 超级管理员2
        /// </summary>
        Manager,

        /// <summary>
        /// 先生3
        /// </summary>
        Mr,

        /// <summary>
        /// 女士4
        /// </summary>
        Lady,

        /// <summary>
        /// 待审核5
        /// </summary>
        Authstr,

        /// <summary>
        /// 通过6
        /// </summary>
        Pass,

        /// <summary>
        /// 驳回7
        /// </summary>
        turndown,

        /// <summary>
        /// 营业8
        /// </summary>
        Business,

        /// <summary>
        /// 停业9
        /// </summary>
        Classdown,

        /// <summary>
        /// 支付10
        /// </summary>
        Pay,

        /// <summary>
        /// 待支付11
        /// </summary>
        UnPay,

        /// <summary>
        /// 配送12
        /// </summary>
        Delivery,

        /// <summary>
        /// 非常好13
        /// </summary>
        VeryGood,


        /// <summary>
        /// 较好14
        /// </summary>
        Good,

        /// <summary>
        /// 一般15
        /// </summary>
        Ordinary,

        /// <summary>
        /// 较差16
        /// </summary>
        Bad,

        /// <summary>
        /// 非常错17
        /// </summary>
        SoBad,

        /// <summary>
        /// 接单18
        /// </summary>
        Order,

        /// <summary>
        /// 拒单19
        /// </summary>
        Single,

        /// <summ ary>
        /// 上架20
        /// </summary>
        Putaway,

        /// <summary>
        /// 下架21
        /// </summary>
        Soldout,


    }
}
