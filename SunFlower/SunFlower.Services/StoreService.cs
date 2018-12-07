﻿using System;
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
    public class StoreService : IStore
    {
        /// <summary>
        /// 申请店铺
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int AddStore(Store store)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"insert into Store(storenumber, storename, storeimg, filename, address, storephone, auditing, state, createtime, edittime, daysale, daymoney, conntent) values(:storenumber, :storename, :storeimg, :filename, :address,: storephone, :auditing, :state, :createtime, :edittime, :daysale, :daymoney, :conntent)";
                var Add = conn.Execute(sql,store);
                return Add;
            }
        }

        /// <summary>
        /// 查看店铺信息
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStores()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Store";
                var soreList = conn.Query<MODEL.Store>(sql, null);
                return soreList.ToList<MODEL.Store>();
            }
        }

        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int UptdateStore(Store store)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update store set storenumber=:storenumber, storename=:storename, storeimg=:storeimg, filename=:filename, address=:address, storephone=:storephone, auditing=:auditing, state=:state, createtime=:createtime, edittime=:edittime, daysale=:daysale, daymoney=:daymoney, conntent=:conntent where id=:ID";
                var update = conn.Execute(sql, store);
                return update;
            }
        }
    }
}