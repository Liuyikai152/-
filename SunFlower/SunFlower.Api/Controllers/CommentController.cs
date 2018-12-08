﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data;
using SunFlower.MODEL;
using SunFlower.Services;

namespace SunFlower.Api.Controllers
{
    /// <summary>
    /// 评论控制器
    /// </summary>
    public class CommentController : ApiController
    {
        CommentsService services = new CommentsService();

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int AddComment(Comments comment)
        {
            var result = services.AddComment(comment);
            return result;
        }

        /// <summary>
        /// 显示评论
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Comments> GetComments()
        {
            var commentsList = services.GetComments();
            return commentsList;
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteComment(int ID)
        {
            var result = services.DeleteComment(ID);
            return result;
        }
    }
}