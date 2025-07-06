using FreeSnow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace FreeSnow.Entities
{
    public class GroupPurchase : AuditedAggregateRoot<Guid>
    {
        //ToDo 这几张表的关系需要配置，在EF里面要配置一对多和多对多的关系
        public string Title { get; set; }         // 拼团标题
        public string Description { get; set; }    // 描述
        public decimal OriginalPrice { get; set; } // 原价
        public decimal GroupPrice { get; set; }    // 拼团价
        public int TargetNumber { get; set; }      // 目标人数
        public int CurrentNumber { get; set; }     // 当前参团人数
        public DateTime StartTime { get; set; }    // 开始时间
        public DateTime EndTime { get; set; }      // 结束时间
        public IdentityUser Creator { get; set; }      // 团长
        public GroupStatus Status { get; set; }    // 拼团状态
        public List<IdentityUser> ParticipantIds { get; set; } = new List<IdentityUser>(); // 参团用户ID列表
        /// <summary>
        ///酒店
        /// </summary>
        public List<Hotel> Hotels { get; set; }= new List<Hotel>();
        /// <summary>
        /// 交通
        /// </summary>
        public List<Transportation> Transportations { get; set; } = new List<Transportation>();
        /// <summary>
        /// 关联的帖子列表
        /// </summary>
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
