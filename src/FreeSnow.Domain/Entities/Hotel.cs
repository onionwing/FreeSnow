using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace FreeSnow.Entities
{
    /// <summary>
    /// 酒店(住宿)实体类
    /// </summary>
    public class Hotel : AuditedEntity<Guid>
    {
        public string Name { get; set; } // 酒店名称
        public string Address { get; set; } // 酒店地址
        public string Description { get; set; } // 酒店描述
        public string? PhoneNumber { get; set; } // 酒店联系电话
    }
}
