using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 购物车明细表
    /// </summary>
   public interface ITrolleyDetails
    {

        /// <summary>
        /// 添加购物城详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        int AddTrolleyDetails(TrolleyDetails trolleyDetails);

        /// <summary>
        /// 显示购物车详情
        /// </summary>
        /// <returns></returns>
        List<TrolleyDetails> GetTrolleyDetails(int id);


        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        List<TrolleyDetails> GetTrolleyByNumber(string TrolleyNumber);
       

        /// <summary>
        /// 修改购物城详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        int UptdateTrolleyDetails(TrolleyDetails trolleyDetails);

        /// <summary>
        /// 删除购物城详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        int deleteTrolleyDetails(int ID);
    }
}
