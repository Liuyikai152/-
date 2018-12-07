using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{

    using MODEL;

    /// <summary>
    /// 优惠接口
    /// </summary>
    public interface IDiscounts
    {
        /// <summary>
        /// 查看优惠劵
        /// </summary>
        /// <returns></returns>
        List<Discounts> GetDiscounts();

        /// <summary>
        /// 添加优惠
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        int AddDiscounts(Discounts discounts);
    }
}
