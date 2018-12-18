using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 购物车表
    /// </summary>
    public interface ITrolley
    {
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        int AddTrolley(Trolley trolley);

        /// <summary>
        /// 显示购物车
        /// </summary>
        /// <returns></returns>
        List<Trolley> GetTrolleys();

        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        int UpdateTrolley(Trolley trolley);

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        int DeleteTrolley(int ID);


        /// <summary>
        /// 根据条件 获取购物车
        /// </summary>
        /// <returns></returns>
        List<Trolley> GetTrolleyByStore(string userID);
       

    }
}
