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
<<<<<<< HEAD




=======
>>>>>>> 4b21647210b9b43c6fa149eb32e0d085f4567564
        /// <summary>
        /// 修改审批
        /// </summary>
        /// <param name="approvalActivity"></param>
        /// <returns></returns>

        int UpdateApprovalActivity(ApprovalActivity approvalActivity);
<<<<<<< HEAD



=======
>>>>>>> 4b21647210b9b43c6fa149eb32e0d085f4567564
    }
}
