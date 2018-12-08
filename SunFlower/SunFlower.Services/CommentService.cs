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
                string sql = @"insert into comments(userid,content,commenttime,storenumber,storetype,commentimg) 
                             values(:userid,:content,:commenttime,:storenumber,:storetype,:commentimg)";
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
                var deleteComment = conn.Execute(sql, new { ID = ID });
                return deleteComment;
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
                string sql = @"select comments.content as content,users.username as username,comments.commenttime as commenttime,comments.storetype as storetype,comments.commentimg as commentimg from comments join users on comments.userid = users.id";
                var commentsList = conn.Query<Comments>(sql, null);
                return commentsList.ToList();
            }
        }
    }
}
