using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SunFlower.IServices;
using SunFlower.Services;
using SunFlower.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using Unity.Attributes;

namespace SunFlower.Api.Controllers
{
    public class TrolleyDetailController : ApiController
    {
     
        [Dependency]
        public ITrolleyDetails TrolleyDetails { get; set; }

        //构造函数
        //public ITrolleyDetails _TrolleyDetails=null;

        //public TrolleyDetailController(ITrolleyDetails trolleyDetails) {

        //    _TrolleyDetails = trolleyDetails;
        //}

        /// <summary>
        /// 添加购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int AddTrolleyDetails(TrolleyDetails trolleyDetails)
        {

            int result = TrolleyDetails.AddTrolleyDetails(trolleyDetails);
            return result;

        }

        /// <summary>
        /// 删除购物车详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int deleteTrolleyDetails(int ID)
        {

            int result = TrolleyDetails.deleteTrolleyDetails(ID);
            return result;

        }

        /// <summary>
        /// 查看购物车详情
        /// </summary>
        /// <returns></returns>
        public List<TrolleyDetails> GetTrolleyDetails()
        {

            var trolleyDetailsList = TrolleyDetails.GetTrolleyDetails();
            return trolleyDetailsList;

        }

        /// <summary>
        /// 修改购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int UptdateTrolleyDetails(TrolleyDetails trolleyDetails)
        {

            int result = TrolleyDetails.UptdateTrolleyDetails(trolleyDetails);
            return result;

        }
    }
}
