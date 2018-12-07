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
    public class FoodTypeService : IFoodType
    {
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
