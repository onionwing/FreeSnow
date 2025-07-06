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
    /// 交通实体类
    /// </summary>
    public class Transportation: AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 公司或个体名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 出发地
        /// </summary>
        public string DeparturePoint { get; set; }
        /// <summary>
        /// 目的地
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// 途径地点
        /// </summary>
        public List<RouteLocation> RouteLocations { get; set; }

    }
}
