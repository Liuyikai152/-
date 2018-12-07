using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunFlower.MODEL
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comments
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        ///评论人
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        public string  Content { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CommentTime{ get; set; }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string StoreNumber { get; set; }

        /// <summary>
        /// 评价类型
        /// </summary>
        public EnumNews StoreType { get; set; }

        /// <summary>
        /// 评价图片
        /// </summary>
        public string  CommentImg { get; set; }
    }
}
