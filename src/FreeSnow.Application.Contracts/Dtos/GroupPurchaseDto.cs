using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSnow.Dtos
{
    public class GroupPurchaseDto
    {
        public string Title { get; set; }         // 拼团标题
        public string Description { get; set; }    // 描述
        public decimal OriginalPrice { get; set; } // 原价
        public decimal GroupPrice { get; set; }    // 拼团价
        public int TargetNumber { get; set; }      // 目标人数
        public int CurrentNumber { get; set; }     // 当前参团人数
        public DateTime StartTime { get; set; }    // 开始时间
        public DateTime EndTime { get; set; }      // 结束时间
        public Guid CreatorId { get; set; }      // 团长ID


    }
}
