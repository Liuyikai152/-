using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 轮播图接口
    /// </summary>
    public interface IBootstrap
    {
        /// <summary>
        /// 获取轮播图
        /// </summary>
        /// <returns></returns>
        List<Bootstrap> GetBootstraps();
    }
}
