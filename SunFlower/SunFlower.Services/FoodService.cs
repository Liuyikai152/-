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
       
        public int AddFood(Food food)
        {
            throw new NotImplementedException();
        }

        public int DeleteFood(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetFoods()
        {
            using ( OracleConnection conn= DapperHelper.GetConnString())
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
