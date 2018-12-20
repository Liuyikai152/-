using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    public interface IApprovalActivity
    {
        /// <summary>
        /// 添加审批活动
        /// </summary>
        /// <returns></returns>
        int AddApprovalActivity();

        /// <summary>
        /// 显示审批活动
        /// </summary>
        /// <returns></returns>
        List<ApprovalActivity> GetApprovalActivity();
    }
}
