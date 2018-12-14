using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunFlower.MODEL;


namespace SunFlower.IServices
{
   public interface IRole
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="t_Role"></param>
        /// <returns></returns>
        int AddRole(Role t_Role);

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteRole(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t_Role"></param>
        /// <returns></returns>
        int UpdateRole(Role t_Role);

        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        List<Role> GetRoles();

       List<Role> GetByID(int id);
    }
}
