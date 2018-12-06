using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 地区接口
    /// </summary>
    public interface IArea
    {
        /// <summary>
        /// 获取地址
        /// </summary>
        /// <returns></returns>
        List<Area> GetAreas(int Pid);
    }
}
