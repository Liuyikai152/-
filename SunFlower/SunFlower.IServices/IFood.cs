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
        /// 查看单个店铺所有菜品
        /// </summary>
        /// <returns></returns>
        List<Food> GetFoods(int id);

        /// <summary>
        /// 根据菜品类别查看单个店铺菜品
        /// </summary>
        /// <returns></returns>
         List<Food> StoreGetFoods(int id, string typename);
       

        /// <summary>
        /// 查看单个菜品
        /// </summary>
        /// <returns></returns>
        List<Food> GetFoodByID(int id);

        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        List<Food> GetFood();
    }
}
