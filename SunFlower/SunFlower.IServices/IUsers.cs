using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 用户接口
    /// </summary>
    public interface IUsers
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int AddUsers(Users users);

        /// <summary>
        /// 查看所有用户
        /// </summary>
        /// <returns></returns>
        List<Users> GetUsers();

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int UptdateUsers(Users users);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int DeleteUsers(int ID);
    }
}
