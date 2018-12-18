using Dapper;
using Oracle.DataAccess.Client;
using SunFlower.Common;
using SunFlower.IServices;
using SunFlower.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.Services
{
    /// <summary>
    /// 菜品类别实现类
    /// </summary>
    public class FoodTypeService : IFoodType
    {
        /// <summary>
        /// 显示所有菜品类型
        /// </summary>
        /// <returns></returns>
        public List<FoodType> GetFoodType()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = "select * from FoodType";
                var foodTypeList = conn.Query<FoodType>(sql, null);
                return foodTypeList.ToList<FoodType>();
            }
        }

        /// <summary>
        /// 显示菜品类别
        /// </summary>
        /// <returns></returns>
        public List<FoodType> GetFoodTypes()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
               string sql= "select FoodType.TypeName from FoodType join Food on FoodType.ID =Food.ID";
                var foodTypeList= conn.Query<FoodType>(sql, null);
                return foodTypeList.ToList<FoodType>();
            }
        }
       
    }
}
