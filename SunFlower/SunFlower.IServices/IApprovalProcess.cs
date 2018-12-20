using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 流程接口
    /// </summary>
    public interface IApprovalProcess
    {
        /// <summary>
        /// 显示所有流程
        /// </summary>
        /// <returns></returns>
        List<ApprovalProcess> GetApprovalProcess();

        /// <summary>
        /// 删除流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteApprovalProcess(int id);

        /// <summary>
        /// 添加流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int AddApprovalProcess(ApprovalProcess approvalProcess);

        /// <summary>
        /// 修改流程
        /// </summary>
        /// <param name="approvalProcess"></param>
        /// <returns></returns>
        int UpdateApprovalProcess(Food approvalProcess);

        /// <summary>
        /// 获取单个流程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<ApprovalProcess> GetApprovalProcessByID(int id);
    }
}
