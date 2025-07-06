using FreeSnow.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace FreeSnow.IApplicationServices
{
    public interface IGroupPurchaseService : IApplicationService
    {
        Task<GroupPurchaseDto> CreateAsync(CreateGroupOrderDto input);
        Task JoinAsync(Guid groupPurchaseId);
    }
}
