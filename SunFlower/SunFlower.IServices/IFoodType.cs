using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 菜品类别接口
    /// </summary>
    public interface IFoodType
    {

        List<FoodType> GetFoodTypes();

        List<FoodType> GetFoodType();


        /// <summary>
        /// 根据店铺编号查询菜品类型
        /// </summary>
        /// <returns></returns>
        List<FoodType> StoreFoodType(int sid);
      
    }
}
