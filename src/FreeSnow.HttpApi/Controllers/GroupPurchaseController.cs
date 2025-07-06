using FreeSnow.Dtos;
using FreeSnow.IApplicationServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace FreeSnow.Controllers
{
    [Route("api/grouppurchase")]
    public class GroupPurchaseController : AbpControllerBase
    {
        private readonly IGroupPurchaseService _groupPurchaseService;

        public GroupPurchaseController(IGroupPurchaseService groupPurchaseService)
        {
            _groupPurchaseService = groupPurchaseService;
        }

        //[HttpPost]
        //public Task<GroupPurchaseDto> Create(CreateGroupOrderDto dto) => _groupPurchaseService.CreateAsync(dto);

        //[HttpPost("{id}/join")]
        //public Task Join(Guid id) => _groupPurchaseService.JoinAsync(id);
    }
}
