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
        /// 根据菜品类别查看单个店铺菜品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("StoreGetFoods")]
        public List<Food> StoreGetFoods(int id, string typename)
        {
            var foodList = Food.StoreGetFoods(id,typename);
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
            food.CreateTime = DateTime.Now;
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
        private const int PAGESIZE = 4;
        [HttpGet]
        [Route("GetFood")]
        public PageBox GetFood( int Page = 1)
        {
            
            List<Food> foodlist = Food.GetFood();
            PageBox pagebox = new PageBox();
            pagebox.PageIndex = Page;          
            pagebox.PageCount = foodlist.Count / PAGESIZE + (foodlist.Count % PAGESIZE == 0 ? 0 : 1);
            pagebox.Data = foodlist.Skip((Page - 1) * PAGESIZE).Take(PAGESIZE);
            return pagebox;
        }
    }
}
