using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 用户日志
    /// </summary>
    public interface IUserLogs
    {

       /// <summary>
       /// 添加日志
       /// </summary>
       /// <param name="userLogs"></param>
       /// <returns></returns>
        int AddLogs(UserLogs userLogs);
        
        /// <summary>
        /// 显示用户日志
        /// </summary>
        /// <returns></returns>
        List<UserLogs> GetUserLogs();
    }
}
