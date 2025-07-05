using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSnow.Enums
{
    public enum GroupStatus
    {
        NotStarted,     // 未开始
        InProgress,     // 进行中
        Success,        // 拼团成功
        Failed,         // 拼团失败
        Closed          // 已关闭
    }
}
