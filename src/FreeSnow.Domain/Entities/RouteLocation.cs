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
    /// 途径地点实体类
    /// </summary>
    public class RouteLocation: AuditedEntity<Guid>
    {
        /// <summary>
        /// 地点名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 地点标志物（如在一个小白兔一样的云下面）
        /// </summary>
        public string Landmark { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
