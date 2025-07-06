using FreeSnow.Dtos;
using FreeSnow.Entities;
using FreeSnow.IApplicationServices;
using FreeSnow.Repositories;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Users;

namespace FreeSnow.ApplicationServices
{
    [Authorize]
    public class GroupPurchaseService : ApplicationService, IGroupPurchaseService
    {
        private readonly IGroupPurchaseRepository _groupPurchaseRepository;
        private readonly ICurrentUser _user;

        public GroupPurchaseService(IGroupPurchaseRepository groupPurchaseRepository, ICurrentUser user)
        {
            _groupPurchaseRepository = groupPurchaseRepository;
            _user = user;
        }

        public  async Task<GroupPurchaseDto> CreateAsync(CreateGroupOrderDto input)
        {
           var group =  GroupPurchase.CreateGroupPurchase(_user?.Id!.Value?? Guid.NewGuid(), input.Title, input.Description, input.OriginalPrice, input.GroupPrice, input.TargetNumber, DateTime.UtcNow.AddDays(1));
                await _groupPurchaseRepository.InsertAsync(group);
            await CurrentUnitOfWork!.SaveChangesAsync();

            return ObjectMapper.Map<GroupPurchase, GroupPurchaseDto>(group);

        }

        public async Task JoinAsync(Guid groupPurchaseId)
        {
            var group = await _groupPurchaseRepository.GetAsync(groupPurchaseId);
            if(group == null) throw  new BusinessException("为找到此拼团");
            group.Join(_user.GetId());
            try {
                await _groupPurchaseRepository.UpdateAsync(group);
            }catch (AbpDbConcurrencyException)
            {
                throw new BusinessException("系统繁忙，请重试");
            }
        }
    }
}
