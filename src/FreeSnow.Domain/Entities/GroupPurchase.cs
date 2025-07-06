using FreeSnow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace FreeSnow.Entities
{
    public class GroupPurchase : AggregateRoot<Guid>
    {
        public string Title { get; set; }         // 拼团标题
        public string Description { get; set; }    // 描述
        public decimal OriginalPrice { get; set; } // 原价
        public decimal GroupPrice { get; set; }    // 拼团价
        public int TargetNumber { get; set; }      // 目标人数
        public int CurrentNumber { get; set; }     // 当前参团人数
        public DateTime StartTime { get; set; }    // 开始时间
        public DateTime EndTime { get; set; }      // 结束时间
        public string CreatorId { get; set; }      // 团长ID
        public GroupStatus Status { get; set; }    // 拼团状态
        //这里不知道怎么对应用户，找不到用户所在的实体类，假设是Guid类型
        public List<Guid> ParticipantIds { get; set; } = new List<Guid>(); // 参团用户ID列表
        /// <summary>
        /// 关联的帖子列表
        /// </summary>
        public List<Post> Posts { get; set; }
    }
}
