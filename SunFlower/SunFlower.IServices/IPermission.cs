
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunFlower.MODEL;


namespace SunFlower.IServices
{
    public interface IPermission
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="t_Permission"></param>
        /// <returns></returns>
        int AddPermission(Permission t_Permission);

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePermission(int id);

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="t_Permission"></param>
        /// <returns></returns>
        int UpdatePermission(Permission t_Permission);

        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        List<Permission> GetPermissions();

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Permission> GetByID(int id);
    }

}

