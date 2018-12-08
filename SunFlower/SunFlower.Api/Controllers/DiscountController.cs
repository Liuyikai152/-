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
    public class DiscountController : ApiController
    {
        [Dependency]
        public IDiscounts Discount { get; set; }
        /// <summary>
        /// 添加优惠券信息
        /// </summary>
        /// <param name="discounts"></param>
        /// <returns></returns>
        public int AddDiscounts(Discounts discounts)
        {
            var result = Discount.AddDiscounts(discounts);
            return result;
        }

        /// <summary>
        /// 显示所有优惠
        /// </summary>
        /// <returns></returns>
        public List<Discounts> GetDiscounts()
        {
            var discountsList = Discount.GetDiscounts();
            return discountsList;
        }
    }
}
