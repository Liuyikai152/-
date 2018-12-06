using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 订单接口
    /// </summary>
   public  interface IUserOrder
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        int AddOrder(UserOrder userOrder);

        /// <summary>
        /// 获取所有订单
        /// </summary>
        /// <returns></returns>
        List<UserOrder> GetUserOrders();

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="userOrder"></param>
        /// <returns></returns>
        int DeleteOrder(UserOrder userOrder);

    }
}
