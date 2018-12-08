using SunFlower.MODEL;
using SunFlower.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity.Attributes;
using SunFlower.IServices;
namespace SunFlower.Api.Controllers
{
    public class FoodTypeController : ApiController
    {
        [Dependency]
        public IFoodType FoodType { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<FoodType> GetFoodTypes()
        {
            var foodTypeList = FoodType.GetFoodTypes();
            return foodTypeList;
        }
    }
}
