using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunFlower.MODEL;


namespace SunFlower.IServices
{
    public interface ITUsers
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        int AddUsers(TUsers t_Users);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUsers(int id);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        int UpdateUsers(TUsers t_Users);

        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        List<TUsers> GetUsers();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        int Login(string userName, string passWord);

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<TUsers> GetByID(int id);

        List<TUsers> GetPermissiomUrl(int id);
    }
}
