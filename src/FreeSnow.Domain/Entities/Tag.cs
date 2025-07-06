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
    /// Tag标签
    /// 这个做成实体方便后续对相应的Tag绑定活动
    /// </summary>
    public class Tag: AuditedEntity<Guid>
    {
        /// <summary>
        /// Tag内容
        /// </summary>
        public string TagName { get; set; }
    }
}
