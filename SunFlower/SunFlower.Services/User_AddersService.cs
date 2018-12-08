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
    public class User_AddersService : IUser_Adders
    {
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="adders"></param>
        /// <returns></returns>
        public int AddUserAdder(User_Adders adders)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into User_Adders (UserID,UserGender,ProvinceID,CityID,DistrictID,ProvinceName,Address,CreateTime, EditTime, IsDefault) values (:UserID,:UserGender,:ProvinceID,:CityID,:DistrictID,:ProvinceName,:Address,:CreateTime,:EditTime,:IsDefault)";
                int result = conn.Execute(sql, adders);
                return result;
            }
        }

        /// <summary>
        /// 删除用户地址
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteUserAdder(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"delete from User_Adders where ID=:ID";
                int result = conn.Execute(sql, new { ID = ID });
                return result;
            }
        }

        /// <summary>
        /// 查看用户地址
        /// </summary>
        /// <returns></returns>
        public List<User_Adders> GetUser_Adders()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Food";
                var user_AddersList = conn.Query<User_Adders>(sql, null);
                return user_AddersList.ToList<User_Adders>();
            }
        }

        /// <summary>
        /// 修改用户地址
        /// </summary>
        /// <param name="adders"></param>
        /// <returns></returns>
        public int UptdateUserAdder(User_Adders adders)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update User_Adders set UserID=:UserID,UserGender=:UserGender,ProvinceID=:,ProvinceID,CityID=:CityID,DistrictID=:DistrictID,ProvinceName=:ProvinceName,Address=:Address,CreateTime=:CreateTime,EditTime=:EditTime, IsDefault=:IsDefault where Id=:Id";
                int result = conn.Execute(sql, adders);
                return result;
            }
        }
    }
}
