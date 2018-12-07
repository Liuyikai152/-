using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.MODEL;
using SunFlower.IServices;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;
namespace SunFlower.Services
{
    /// <summary>
    /// 添加优惠信息
    /// </summary>
    public class DiscountService : IDiscounts
    {
        /// <summary>
        /// 添加优惠券信息
        /// </summary>
        /// <param name="discounts"></param>
        /// <returns></returns>
        public int AddDiscounts(Discounts discounts)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Discounts (discount,money_off,storenumber,createtime,edittime)values(:discount,:money_off,:storenumber,:createtime,:edittime))";
                var Add = conn.Execute(sql,discounts);
                return Add();
            }
        }

        /// <summary>
        /// 显示所有优惠
        /// </summary>
        /// <returns></returns>
        public List<Discounts> GetDiscounts()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Discounts";
                var discountList = conn.Query<Discounts>(sql,null);
                return discountList.ToList<Discounts>();
            }
        }
    }
}
