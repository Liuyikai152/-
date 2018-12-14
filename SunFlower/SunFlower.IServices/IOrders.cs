using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;


    /// <summary>
    /// 订单详情接口
    /// </summary>
    public interface IOrders
    {
        /// <summary>
        /// 添加订单详情
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        int AddOrders(Orders orders);

        /// <summary>
        /// 查看订单详情
        /// </summary>
        /// <returns></returns>
        List<Orders> GetOrders();

        /// <summary>
        /// 获取单个订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Orders> GetOrder(int id);
    }
}
