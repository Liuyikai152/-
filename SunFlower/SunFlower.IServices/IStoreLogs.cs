using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 商家日志接口
    /// </summary>
   public interface IStoreLogs
    {
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <returns></returns>
        int AddStoreLogs(StoreLogs storeLogs);

        /// <summary>
        /// 显示日志
        /// </summary>
        /// <returns></returns>
        List<StoreLogs> GetStoreLogs();


    }
}
