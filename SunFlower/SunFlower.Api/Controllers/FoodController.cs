using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;
using Unity.Attributes;
using SunFlower.IServices;
namespace SunFlower.Api.Controllers
{
    [RoutePrefix("Food")]
    public class FoodController : ApiController
    {
        [Dependency]
        public IFood Food { get; set; }
        /// <summary>
        /// 查看点个店铺所有菜品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFoods")]
        public List<Food> GetFoods(int id)
        {
            var foodList = Food.GetFoods(id);
            return foodList;
        }

        /// <summary>
        /// 查看单个菜品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFoodByID")]
        public List<Food> GetFoodByID(int id)
        {

            var foodList = Food.GetFoodByID(id);
            return foodList;
        }

        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddFood")]
        public int AddFood(Food food)
        {

            var result = Food.AddFood(food);
            return result;
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteFood")]
        public int DeleteFood(int ID)
        {
            var result = Food.DeleteFood(ID);
            return result;
        }

        /// <summary>
        /// 修改单个菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateFood")]
        public int UpdateFood(Food food)
        {
            int result = Food.UpdateFood(food);
            return result;
        }
    }
}
