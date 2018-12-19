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
                string sql = @"insert into Food (foodnumber,storenumber,foodname,filename,foodsummary,foodsprice,createtime, foodtypeid) values(:foodnumber,:storenumber,:foodname,:filename,:foodsummary,:foodsprice,:createtime,:foodtypeid)";
                
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
        /// 查看点个店铺所有菜品
        /// </summary>
        /// <returns></returns>
        public List<Food> GetFoods(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select f.id, s.storenumber, f.foodname,f.filename,f.foodsprice,f.sale from food f join Store s on(f.storenumber=s.storenumber) where s.id=:id order by ID desc";
                var foodList = conn.Query<Food>(sql, new { id = id });
                return foodList.ToList<Food>();
            }
        }

        /// <summary>
        /// 查看单个菜品
        /// </summary>
        /// <returns></returns>
        public List<Food> GetFoodByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select f.id,f.foodsprice,f.foodnumber,s.storenumber, f.foodname,f.filename,f.foodsprice,f.sale,f.foodsummary from food f join Store s on(f.storenumber=s.storenumber) where f.id=:id order by ID desc";
                var foodList = conn.Query<Food>(sql, new { id = id });
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
                int result = conn.Execute(sql, food);
                return result;
            }
        }

        public List<Food> GetFood()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @" select f.id,f.foodnumber,f.foodname,f.storenumber,f.createtime,f.foodsprice,f.filename,t.typename,s.storename,f.foodsummary from Food f left join foodtype t on f.foodtypeid=t.id join store s on f.storenumber=s.storenumber ";
                var foodList = conn.Query<Food>(sql, null);
                return foodList.ToList<Food>();
            }
        }
    }
}
