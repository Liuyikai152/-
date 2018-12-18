using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 收藏接口
    /// </summary>
    public interface ICollect
    {

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="collect"></param>
        /// <returns></returns>
        int AddCollect(Collect collect);

        /// <summary>
        /// 查看收藏
        /// </summary>
        /// <returns></returns>
        List<Collect> GetCollects();

        /// <summary>
        /// 查看单个收藏
        /// </summary>
        /// <returns></returns>
        List<Collect> GetCollectByID(string storenumber);
    }
}
