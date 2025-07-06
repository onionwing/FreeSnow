using FreeSnow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace FreeSnow.Entities
{
    public class GroupPurchase : AuditedAggregateRoot<Guid>
    public class GroupPurchase : FullAuditedAggregateRoot<Guid>, IHasConcurrencyStamp
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
        public List<Post> Posts { get; private set; }

        public bool IsExpired => DateTime.UtcNow > EndTime;

        /// <summary>
        /// 乐观锁
        /// </summary>
        public string ConcurrencyStamp { get; set; }
        /// <summary>
        /// 创建拼团
        /// </summary>
        /// <param name="creatorId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="originalPrice"></param>
        /// <param name="groupPrice"></param>
        /// <param name="targetNumber"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static GroupPurchase CreateGroupPurchase(Guid creatorId, string title, string description, decimal originalPrice, decimal groupPrice, int targetNumber, DateTime endTime)
        {

            var group = new GroupPurchase
            {
                Title = title,
                Description = description,
                OriginalPrice = originalPrice,
                GroupPrice = groupPrice,
                TargetNumber = targetNumber,
                CurrentNumber = 1, // 创建时团长自动加入
                StartTime = DateTime.Now,
                EndTime = endTime,
                CreatorId = creatorId,
                Status = GroupStatus.InProgress
            };

            group.ParticipantIds.Add(creatorId);
            return group;
        }


        // 加入拼团
        public void Join(Guid userId)
        {
            if (IsExpired) throw new BusinessException("拼团已过期");

            if (Status != GroupStatus.InProgress)
                throw new BusinessException("拼团已结束，无法加入");

            if (ParticipantIds.Any(p => p == userId))
                throw new BusinessException("用户已参与此拼团");

            ParticipantIds.Add(userId);

            // 检查是否达到目标人数
            if (ParticipantIds.Count >= TargetNumber)
            {
                Status = GroupStatus.Success;
            }
        }


    }
}
