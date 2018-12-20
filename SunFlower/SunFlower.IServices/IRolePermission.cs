using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunFlower.MODEL;


namespace SunFlower.IServices
{
    public interface IRolePermission
    {
        /// <summary>
        /// 添加
        /// </summary> 
        /// <param name="role_Permission"></param>
        /// <returns></returns>
        int AddRolePermission(RolePermission role_Permission);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteRolePermission(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="role_Permission"></param>
        /// <returns></returns>
        int UpdateRolePermission(RolePermission role_Permission);

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<RolePermission> GetRolePermissions();
    }
}
