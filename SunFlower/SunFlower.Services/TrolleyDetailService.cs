﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.IServices;
using SunFlower.MODEL;
using Dapper;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;

namespace SunFlower.Services
{
    public class TrolleyDetailService : ITrolleyDetails
    {



        /// <summary>
        /// 添加购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int AddTrolleyDetails(TrolleyDetails trolleyDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into trolleydetails(trolleynumber,userid,foodnumber,createtime,num,money,prices) values(:trolleynumber,:userid,:foodnumber,:createtime,:num,:money,:prices)";
                int result = conn.Execute(sql, trolleyDetails);

                return result;
            }
        }

        /// <summary>
        /// 删除购物车详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int deleteTrolleyDetails(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"delete from trolleydetails where id=:id";
                int result = conn.Execute(sql, new { id = ID });
                return result;
            }
        }

        /// <summary>
        /// 查看购物车详情
        /// </summary>
        /// <returns></returns>
        public List<TrolleyDetails> GetTrolleyDetails(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"select e.id,a.trolleynumber,e.foodnumber,e.foodname,e.filename,a.num,a.num*e.foodsprice as money,e.foodsprice from trolleydetails a join Users b on (a.userid=b.id) join food e on(a.foodnumber=e.foodnumber)where a.userid=:id";
                var trolleyDetailsList = conn.Query<TrolleyDetails>(sql, new { id = id });
                if (trolleyDetailsList != null)
                {
                    return trolleyDetailsList.ToList();
                }
                return null;
            }
        }

        /// <summary>
        /// 修改购物车详情
        /// </summary>
        /// <param name="trolleyDetails"></param>
        /// <returns></returns>
        public int UptdateTrolleyDetails(TrolleyDetails trolleyDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"update trolleydetails set trolleynumber=:trolleynumber,userid=:userid,foodnumber=:foodnumber,createtime=:createtime,num=:num,money=:money,prices=:prices where id=:id";
                int result = conn.Execute(sql, trolleyDetails);
                return result;
            }
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public List<TrolleyDetails> GetTrolleyByNumber(string Number)
        {
            using (OracleConnection conn = DapperHelper.GetConnString()) {
                conn.Open();
                string sql = @"select * from trolley t join trolleydetails d on t.trolleynumber=d.trolleynumber where d.trolleynumber=:Number";
                var trolleyDetailsList = conn.Query<TrolleyDetails>(sql, new { Number = Number });
                return trolleyDetailsList.ToList();

            }
        }
    }
}
