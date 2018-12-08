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
    public class FoodController : ApiController
    {
        [Dependency]
        public IFood Food { get; set; }
        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Food> GetFoods()
        {
            var foodList = Food.GetFoods();
            return foodList;
        }

        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddFood(Food food)
        {
            //Food food=new Food();
            //food.FoodNumber = "C002";
            //food.StoreNumber = "S001";
            //food.FoodName = "乌龟汤";
            //food.FileName = "cai.png";
            //food.FoodSummary = "大补,清淡";
            //food.FoodSprice = 368.88;
            //food.CreateTime = DateTime.Now;
            //food.Sale = 1;
            //food.State = EnumNews.Putaway;
            //food.FoodTypeID = 1;
            var result = Food.AddFood(food);
            return result;
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
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
        public int UpdateFood(Food food)
        {
            //Food food = new Food();
            //food.ID = 2;
            //food.FoodNumber = "C002";
            //food.StoreNumber = "S001";
            //food.FoodName = "王八汤";
            //food.FileName = "cai.png";
            //food.FoodSummary = "大补,清淡";
            //food.FoodSprice = 368.88;
            //food.CreateTime = DateTime.Now;
            //food.Sale = 1;
            //food.State = EnumNews.Putaway;
            //food.FoodTypeID = 1;

            int result = Food.UpdateFood(food);
            return result;
        }
    }
}
