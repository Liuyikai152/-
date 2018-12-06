using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 用户配送地址接口 
    /// </summary>
   public interface IUser_Adders
    {
        /// <summary>
        /// 添加用户地址
        /// </summary>
        /// <param name="adders"></param>
        /// <returns></returns>
        int AddUserAdder(User_Adders adders);

        /// <summary>
        /// 获取配送地址
        /// </summary>
        /// <returns></returns>
        List<User_Adders> GetUser_Adders();

        /// <summary>
        /// 修改用户地址
        /// </summary>
        /// <param name="adders"></param>
        /// <returns></returns>
        int UptdateUserAdder(User_Adders adders);

        /// <summary>
        /// 删除用户地址
        /// </summary>
        /// <param name="adders"></param>
        /// <returns></returns>
        int DeleteUserAdder(int ID);

    }
}
