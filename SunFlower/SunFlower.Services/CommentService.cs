using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.MODEL;
using SunFlower.IServices;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;

namespace SunFlower.Services
{
    /// <summary>
    /// 评论实现类
    /// </summary>
    public class CommentsService : IComment
    {
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public int AddComment(Comments comment)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = @"insert into comments(content,userid,storenumber,CommentTime) 
             values(:content,:userid,:storenumber,:CommentTime)";
                int result = conn.Execute(sql, comment);
                return result;
            }
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteComment(int ID)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"delete comments where id=:id";
                var result = conn.Execute(sql, new { ID = ID });
                return result;
            }
        }

        /// <summary>
        /// 显示评论
        /// </summary>
        /// <returns></returns>
        public List<Comments> GetComments()
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = @"select c.content,c.commenttime,s.storename,s.storeimg from comments c join store s on(c.storenumber=s.storenumber) join users u on(c.userid=u.id)";
                var commentsList = conn.Query<Comments>(sql, null);
                return commentsList.ToList();
            }
        }
    }
}
