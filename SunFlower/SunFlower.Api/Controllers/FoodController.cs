using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;

namespace SunFlower.Api.Controllers
{
    public class FoodController : ApiController
    {
        FoodService services = new FoodService();
        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Food> GetFoods()
        {
            var foodList = services.GetFoods();
            return foodList;
        }
        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddFood()
        {
            Food food=new Food();
            food.FoodNumber = "C002";
            food.StoreNumber = "S001";
            food.FoodName = "乌龟汤";
            food.FileName = "cai.png";
            food.FoodSummary = "大补,清淡";
            food.FoodSprice = 368.88;
            food.CreateTime = DateTime.Now;
            food.Sale = 1;
            food.State = EnumNews.Putaway;
            food.FoodTypeID = 1;
            var Add = services.AddFood(food);
            return 1;
        }
    }
}
