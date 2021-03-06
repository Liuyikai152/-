﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;


    /// <summary>
    /// 商家接口
    /// </summary>
    public interface IStore
    {
        /// <summary>
        ///添加商家
        /// </summary>
        /// <returns></returns>
        int AddStore(Store store);

        /// <summary>
        /// 显示商家
        /// </summary>
        /// <returns></returns>
        List<Store> GetStores();


        /// <summary>
        /// 显示商家
        /// </summary>
        /// <returns></returns>
        List<Store> ShowStores(int Auditing);

        /// <summary>
        /// 查看所有店铺信息
        /// </summary>
        /// <returns></returns>
        List<Store> GetStoreShow();
       


        /// <summary>
        /// 销量显示
        /// </summary>
        /// <returns></returns>

        List<Store> GetStoresSales();

        /// <summary>
        /// 获取单个店铺
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Store> GetStore(int id);

        /// <summary>
        ///修改商家
        /// </summary>
        /// <returns></returns>
        int UptdateStore(Store store);


        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        int UptdateBoStoreState(int ID, int state);

        /// <summary>
        /// 修改店铺信息
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        int UptdateToStoreState(int ID, int state);


    }
}
