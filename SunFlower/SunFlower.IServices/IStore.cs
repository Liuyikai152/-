using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;


    /// <summary>
    /// 商家接口
    /// </summary>
    public interface IStore
    {
        /// <summary>
        ///添加商家
        /// </summary>
        /// <returns></returns>
        int AddStore(Store store);

        /// <summary>
        /// 显示商家
        /// </summary>
        /// <returns></returns>
        List<Store> GetStores();

        /// <summary>
        ///修改商家
        /// </summary>
        /// <returns></returns>
        int UptdateStore(Store store);

      
    }
}
