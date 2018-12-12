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
                int result = conn.Execute(sql, food);
                return result;
            }
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteFood(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"delete from Food where ID=:ID";
                int result = conn.Execute(sql, new { ID = ID });
                return result;
            }
        }

        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        public List<Food> GetFoods()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select filename,foodname,foodsprice,sale from food";
                var foodList = conn.Query<Food>(sql, null);
                return foodList.ToList<Food>();
            }
        }

        /// <summary>
        /// 修改单个菜品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public int UpdateFood(Food food)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update Food set foodnumber=:foodnumber,storenumber=:storenumber,foodname=:foodname,filename=:filename,foodsummary=:foodsummary,foodsprice=:foodsprice,createtime=:createtime,sale=:sale,state=:state, foodtypeid=:foodtypeid where id=:id";
                int result = conn.Execute(sql,food);
                return result;
            }
        }
    }
}
