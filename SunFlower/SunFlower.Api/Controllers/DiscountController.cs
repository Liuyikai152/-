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
    public class DiscountController : ApiController
    {
        DiscountService discountService = new DiscountService();
        /// <summary>
        /// 添加优惠券信息
        /// </summary>
        /// <param name="discounts"></param>
        /// <returns></returns>
        public int AddDiscounts(Discounts discounts)
        {
            var add = discountService.AddDiscounts(discounts);
            return add;
        }

        /// <summary>
        /// 显示所有优惠
        /// </summary>
        /// <returns></returns>
        public List<Discounts> GetDiscounts()
        {
            var discountsList = discountService.GetDiscounts();
            return discountsList;
        }
    }
}
