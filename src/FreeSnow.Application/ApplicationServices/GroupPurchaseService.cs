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
using Volo.Abp.Identity;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Users;

namespace FreeSnow.ApplicationServices
{
    [Authorize]
    public class GroupPurchaseService : ApplicationService, IGroupPurchaseService
    {
        private readonly IGroupPurchaseRepository _groupPurchaseRepository;
        private readonly ICurrentUser _user;
        private readonly IIdentityUserRepository _identityUserRepository;

        public GroupPurchaseService(IGroupPurchaseRepository groupPurchaseRepository, ICurrentUser user, IIdentityUserRepository identityUserRepository)
        {
            _groupPurchaseRepository = groupPurchaseRepository;
            _user = user;
            _identityUserRepository = identityUserRepository;
        }

        public  async Task<GroupPurchaseDto> CreateAsync(CreateGroupOrderDto input)
        {
           var curIdentityUser = await _identityUserRepository.GetAsync(_user.GetId());
           var group =  GroupPurchase.CreateGroupPurchase(curIdentityUser, input.Title, input.Description, input.OriginalPrice, input.GroupPrice, input.TargetNumber, DateTime.UtcNow.AddDays(1));
                await _groupPurchaseRepository.InsertAsync(group);
            await CurrentUnitOfWork!.SaveChangesAsync();

            return ObjectMapper.Map<GroupPurchase, GroupPurchaseDto>(group);

        }

        public async Task JoinAsync(Guid groupPurchaseId)
        {
            var curIdentityUser = await _identityUserRepository.GetAsync(_user.GetId());
            var group = await _groupPurchaseRepository.GetAsync(groupPurchaseId);
            if(group == null) throw  new BusinessException("未找到此拼团");
            group.Join(curIdentityUser);
            try {
                await _groupPurchaseRepository.UpdateAsync(group);
            }catch (AbpDbConcurrencyException)
            {
                throw new BusinessException("系统繁忙，请重试");
            }
        }
    }
}
