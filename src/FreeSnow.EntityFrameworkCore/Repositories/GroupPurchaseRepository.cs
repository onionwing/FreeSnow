using FreeSnow.Entities;
using FreeSnow.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Linq;

namespace FreeSnow.Repositories
{
    public class GroupPurchaseRepository : EfCoreRepository<FreeSnowDbContext, GroupPurchase, Guid>, IGroupPurchaseRepository
    {
        public GroupPurchaseRepository(IDbContextProvider<FreeSnowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
