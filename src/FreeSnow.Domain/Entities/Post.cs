﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace FreeSnow.Entities
{
    /// <summary>
    /// 帖子
    /// </summary>
    public class Post:FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Body {get;set; }
        /// <summary>
        /// Tag标签
        /// </summary>
        public List<Tag> Tags { get; set; }=new List<Tag>();
        /// <summary>
        /// 关联的团拼
        /// </summary>
        public List<GroupPurchase> GroupPurchases { get; set; } = new List<GroupPurchase>();
    }
}
