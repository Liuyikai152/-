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
    [RoutePrefix("FoodType")]
    public class FoodTypeController : ApiController
    {
        [Dependency]
        public IFoodType FoodType { get; set; }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFoodTypes")]
        public List<FoodType> GetFoodTypes()
        {
            var foodTypeList = FoodType.GetFoodTypes();
            return foodTypeList;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFoodType")]
        public List<FoodType> GetFoodType()
        {
            var foodTypeList = FoodType.GetFoodType();
            return foodTypeList;
        }
    }
}
