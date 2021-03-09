using Marketplace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Domain.Repositories
{
    public interface ISuperOrderRepository
    {
        IQueryable<SuperOrder> SuperOrders { get; }
        void Save(SuperOrder entity);
        void Delete(SuperOrder entity);
        void Update(SuperOrder entity);
    }
}
