using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.IServices
{
    using MODEL;

    /// <summary>
    /// 评论接口
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <returns></returns>
        int AddComment(Comments comment);

        /// <summary>
        /// 查看评论
        /// </summary>
        /// <returns></returns>
        List<Comments> GetComments();

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        int DeleteComment(int ID);
 
    }
}
