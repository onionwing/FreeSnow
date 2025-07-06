using System;
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
        /// Tag列表
        /// </summary>
        public List<Guid> TagIds { get; set; }
        /// <summary>
        /// 关联的拼团列表
        /// </summary>
        public List<GroupPurchase> GroupPurchases { get; set; } = new List<GroupPurchase>();
    }
}
