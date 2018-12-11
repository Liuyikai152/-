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
        /// 销量显示
        /// </summary>
        /// <returns></returns>

        List<Store> GetStoresSales();
      


        /// <summary>
        ///修改商家
        /// </summary>
        /// <returns></returns>
        int UptdateStore(Store store);


        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        int UptdateStoreState(int ID, int state);
       
    }
}
