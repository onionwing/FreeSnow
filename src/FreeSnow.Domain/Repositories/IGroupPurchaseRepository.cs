﻿using FreeSnow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FreeSnow.Repositories
{
    public interface IGroupPurchaseRepository : IRepository<GroupPurchase, Guid>
    {
       
    }
}
