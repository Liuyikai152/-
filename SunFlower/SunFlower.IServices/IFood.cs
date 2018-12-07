using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 菜品接口
    /// </summary>
    public interface IFood
    {
        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        int AddFood(Food food);

        /// <summary>
        /// 修改菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        int UpdateFood(Food food);

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        int DeleteFood(int ID);

        /// <summary>
        /// 查询菜品
        /// </summary>
        /// <returns></returns>
        List<Food> GetFoods();
          
    }
}
