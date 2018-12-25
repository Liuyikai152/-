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
                string sql = @"insert into Store(storenumber, storename, address, storephone, auditing, state, createtime, edittime, conntent, storetype) values(:storenumber, :storename,:address,:storephone, :auditing, :state, :createtime, :edittime,:conntent,:storetype)";
                var result = conn.Execute(sql,store);
                return result;
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
                string sql = @"select * from Store where auditing=6";
                var soreList = conn.Query<MODEL.Store>(sql, null);
                return soreList.ToList<MODEL.Store>();
            }
        }

        /// <summary>
        /// 查看所有店铺信息
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStoreShow()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Store ";
                var soreList = conn.Query<MODEL.Store>(sql, null);
                return soreList.ToList<MODEL.Store>();
            }
        }

        /// <summary>
        ///查询单个店铺 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Store> GetStore(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select ID,storename,storeimg,storenumber  from  Store where id=:id and auditing=6";
                var soreList = conn.Query<MODEL.Store>(sql, new { id = id });
                return soreList.ToList<MODEL.Store>();
            }
        }

        /// <summary>
        /// 销量显示
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStoresSales()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Store  where auditing=6 order by daysale desc ";
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
                var result = conn.Execute(sql, store);
                return result;
            }
        }

        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int UptdateBoStoreState(int ID ,int state)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update store set  state=:state where id=:ID";
                var result = conn.Execute(sql, new { id=ID,state=state});
                return result;
            }
        }
        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public int UptdateToStoreState(int ID, int state)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update store set  Auditing=:Auditing where id=:ID";
                var result = conn.Execute(sql, new { ID = ID, Auditing = state });
                return result;
            }
        }

        /// <summary>
        /// 查看所有商铺
        /// </summary>
        /// <returns></returns>
        public List<Store> ShowStores(int Auditing)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select * from Store where Auditing =:Auditing ";
                var soreList = conn.Query<MODEL.Store>(sql, new { Auditing=Auditing });
                return soreList.ToList<MODEL.Store>();
            }
        }

       
    }
}
