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
    }
}
