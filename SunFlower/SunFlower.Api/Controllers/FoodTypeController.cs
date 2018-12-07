using SunFlower.MODEL;
using SunFlower.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunFlower.Api.Controllers
{
    public class FoodTypeController : ApiController
    {
        FoodTypeService services = new FoodTypeService();

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<FoodType> GetFoodTypes()
        {
            var foodTypeList = services.GetFoodTypes();
            return foodTypeList;
        }
    }
}
