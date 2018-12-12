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
                string sql = @"insert into Store(storenumber, storename, storeimg, filename, address, storephone, auditing, state, createtime, edittime, daysale, daymoney, conntent) values(:storenumber, :storename, :storeimg, :filename, :address,:storephone, :auditing, :state, :createtime, :edittime, :daysale, :daymoney, :conntent)";
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
                string sql = @"select storename,storeimg  from  Store where id=3";
                var soreList = conn.Query<MODEL.Store>(sql, null);
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
                string sql = @"select * from Store order by daysale desc";
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
        public int UptdateStoreState(int ID ,int state)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"update store set  state=:state where id=:ID";
                var result = conn.Execute(sql, new { id=ID,state=state});
                return result;
            }
        }
    }
}
