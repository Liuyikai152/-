using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    public interface IProcessConfiguration
    {
        /// <summary>
        /// 添加流程配置
        /// </summary>
        /// <param name="processConfiguration"></param>
        /// <returns></returns>
        int AddConfiguration(ProcessConfiguration processConfiguration);
        /// <summary>
        /// 显示流程配置
        /// </summary>
        /// <returns></returns>
        List<ProcessConfiguration> GetProcessConfiguration();

        /// <summary>
        /// 删除流程配置
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int DeleteConfiguration(int id);
    }
}
