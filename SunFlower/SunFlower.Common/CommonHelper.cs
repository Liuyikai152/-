using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.Common
{
  public   class CommonHelper
    {
        #region 获取配置文件Key对应Value值
        /// <summary>
        /// 获取配置文件Key对应Value值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
        #endregion
    }
}
