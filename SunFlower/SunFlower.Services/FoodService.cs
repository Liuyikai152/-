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
    /// 菜品实现类
    /// </summary>
    public class FoodService : IFood
    {
        /// <summary>
        /// 添加所有菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public int AddFood(Food food)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Food (foodnumber,storenumber,foodname,filename,foodsummary,foodsprice,createtime,sale, state, foodtypeid) values(:foodnumber,:storenumber,:foodname,:filename,:foodsummary,:foodsprice,:createtime,:sale,:state,:foodtypeid)";
                int Add = conn.Execute(sql,food);
                return Add;
            }
        }

        public int DeleteFood(int ID)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        public List<Food> GetFoods()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from Food");
                var foodList = conn.Query<Food>(sql, null);
                return foodList.ToList<Food>();
            }
        }

        public int UpdateFood(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
