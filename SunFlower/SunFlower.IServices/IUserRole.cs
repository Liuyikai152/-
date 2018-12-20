using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunFlower.MODEL;


namespace SunFlower.IServices
{
    public interface IUserRole
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="user_Role"></param>
        /// <returns></returns>
        int AddUserRole(UserRole user_Role);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUserRole(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user_Role"></param>
        /// <returns></returns>
        int UpdateUserRole(UserRole user_Role);

        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        List<UserRole> GetUserRoles();




    }
}
