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
    public class GroupPurchase : FullAuditedAggregateRoot<Guid>, IHasConcurrencyStamp
    {
        public string Title { get; private set; }         // 拼团标题
        public string Description { get; private set; }    // 描述
        public decimal OriginalPrice { get; private set; } // 原价
        public decimal GroupPrice { get;  private set; }    // 拼团价
        public int TargetNumber { get; private set; }      // 目标人数
        public int CurrentNumber { get; private set; }     // 当前参团人数
        public DateTime StartTime { get; private set; }    // 开始时间
        public DateTime EndTime { get; private set; }      // 结束时间
        public Guid? CreatorId { get; private set; }      // 团长ID
        public GroupStatus Status { get; private set; }    // 拼团状态
        //这里不知道怎么对应用户，找不到用户所在的实体类，假设是Guid类型
        public List<Guid> ParticipantIds { get; private set; } = new List<Guid>(); // 参团用户ID列表
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
